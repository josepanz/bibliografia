Imports System.Data.SqlClient
Public Class bibliografia
    Dim Transac As SqlTransaction
    Dim BibliografiaID As Integer
    Dim vLibro As Integer
    Dim transaccionActivo As Boolean
    Dim vNuevo As Boolean = True
    Dim modo As String
    Dim dv As New DataView

    Private Sub bibliografia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transaccionActivo = False
        With cboLibro
            .DisplayMember = "titulo"
            .ValueMember = "id"
            .DataSource = generar_datatabla("select * from libro")
            .SelectedValue = -1
        End With
        With cboMateria
            .DisplayMember = "descripcion_materia"
            .ValueMember = "id"
            .DataSource = generar_datatabla("select * from materia")
            .SelectedValue = -1
        End With
        With cboPromocion
            .DisplayMember = "descripcion_promocion"
            .ValueMember = "id"
            .DataSource = generar_datatabla("select * from promocion")
            .SelectedValue = -1
        End With
        gbxLibro.Enabled = False
    End Sub

    Private Sub btnHabilitarDetalle_Click(sender As Object, e As EventArgs) Handles btnHabilitarDetalle.Click
        modo = "i"
        If cboMateria.Text = "" Then
            cboMateria.Focus()
            MsgBox("Debe seleccionar una Materia")
            Exit Sub
        End If

        If cboPromocion.Text = "" Then
            cboPromocion.Focus()
            MsgBox("Debe seleccionar una Promocion")
            Exit Sub
        End If
        If nudAnho.Value = 0 Then
            nudAnho.Focus()
            MsgBox("Debe ingresar Anho")
            Exit Sub
        End If
        If txtDescripcion.Text = "" Then
            txtDescripcion.Focus()
            MsgBox("Debe ingresar Descripcion")
            Exit Sub
        End If

        Transac = IniciarTransaccion()
        transaccionActivo = True
        EjecutarSQL("Insert into bibliografia values(@1,@2,@3,@4)", Transac, cboMateria.SelectedValue, cboPromocion.SelectedValue, nudAnho.Value, txtDescripcion.Text)

        gbxLibro.Enabled = True
        btnHabilitarDetalle.Enabled = False
        btnEliminar.Enabled = True
        btnAgregar.Enabled = True
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        cboLibro.Focus()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If modo = "I" Then
                If cboLibro.Text = "" Then
                    cboLibro.Focus()
                    MsgBox("Debe seleccionar un Libro.")
                    Exit Sub
                End If

                For Each row As DataGridViewRow In dgvDetalle.Rows
                    If CStr(row.Cells("Id").Value) = cboLibro.SelectedValue Then
                        MsgBox("ESTE LIBRO YA ESTA CARGADO.")
                        cboLibro.Focus()
                        Exit Sub
                        Exit For
                    End If
                Next



                BibliografiaID = TraerValor("select max(id) from bibliografia", Transac)
                EjecutarSQL("insert into detalle_bibliografia values (@1,@2,@3)", Transac, BibliografiaID, cboLibro.SelectedValue, txtDescripcion.Text)
                ActualizarGrilla()

                cboLibro.SelectedValue = -1
            ElseIf modo = "A" Then
                For Each row As DataGridViewRow In dgvDetalle.Rows
                    If CStr(row.Cells("Id").Value) = cboLibro.SelectedValue Then
                        MsgBox("ESTE LIBRO YA ESTA CARGADO.")
                        cboLibro.Focus()
                        cboLibro.SelectedValue = -1
                        Exit Sub
                        Exit For
                    Else

                        EjecutarSQL("insert into detalle_bibliografia values (@1,@2,@3)", Transac, nudBibliografiaID.Value, cboLibro.SelectedValue, txtDescripcion.Text)
                        RecargarGrilla()
                        MsgBox("SE INSERTO EL LIBRO.")
                        cboLibro.SelectedValue = -1
                    End If
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            transaccionActivo = False
            AnularTransaccion(Transac)
        End Try
    End Sub
    Sub ActualizarGrilla()
        dgvDetalle.DataSource = generar_datatabla("select db.libro_id as Id,li.isbn as ISBN ,li.titulo as Titulo,
a.nombre_autor as Autor,e.nombre_editorial as Editorial,ed.descripcion as Edicion,li.ano_publicacion as AnhoPublicacion
from detalle_bibliografia db join libro li on li.id=db.libro_id
join autor a on a.id=li.autor_id
join editorial e on e.id=li.editorial_id
join edicion ed on ed.id=li.edicion_id
where db.id=" & BibliografiaID, Transac)

    End Sub

    Sub RecargarGrilla()
        dgvDetalle.DataSource = generar_datatabla("select db.libro_id as Id,li.isbn as ISBN ,li.titulo as Titulo,
a.nombre_autor as Autor,e.nombre_editorial as Editorial,ed.descripcion as Edicion,li.ano_publicacion as AnhoPublicacion
from detalle_bibliografia db join libro li on li.id=db.libro_id
join autor a on a.id=li.autor_id
join editorial e on e.id=li.editorial_id
join edicion ed on ed.id=li.edicion_id
where db.id=" & nudBibliografiaID.Value, Transac)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MessageBox.Show("¿Está seguro de confirmar la Bibliografia?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If dgvDetalle.Rows.Count = 0 Then
                MessageBox.Show("Debe cargar al menos un libro")
            Else
                ConfirmarTransaccion(Transac)
                transaccionActivo = False
                btnHabilitarDetalle.Enabled = True
                btnAgregar.Enabled = False
                btnEliminar.Enabled = False
                LimpiarFormulario()
            End If
        End If
    End Sub

    Sub LimpiarFormulario()
        txtDescripcion.Clear()
        cboMateria.SelectedIndex = -1
        cboPromocion.SelectedIndex = -1
        nudAnho.Value = 0
        For h As Integer = dgvDetalle.RowCount - 1 To 0 Step -1

            Dim row As DataGridViewRow = dgvDetalle.Rows(h)

            dgvDetalle.Rows.Remove(row)
        Next
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Desea cancelar la Venta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            AnularTransaccion(Transac)
            transaccionActivo = False
            btnAgregar.Enabled = False
            btnEliminar.Enabled = False
            LimpiarFormulario()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Está seguro de eliminar el Libro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Try
                If modo = "I" Then
                    EjecutarSQL("delete from detalle_bibliografia where id = @1 AND libro_id = @2", Transac, BibliografiaID, vLibro)
                    ActualizarGrilla()
                ElseIf modo = "A" Then
                    EjecutarSQL("delete from detalle_bibliografia where id = @1 AND libro_id = @2", Transac, nudBibliografiaID.Value, vLibro)
                    RecargarGrilla()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al momento de eliminar Libro" & vbNewLine & ex.Message())
                transaccionActivo = False
                AnularTransaccion(Transac)
            End Try

        End If
    End Sub

    Private Sub dgvDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellClick
        Dim row As DataGridViewRow
        row = dgvDetalle.CurrentRow
        vLibro = row.Cells("Id").Value
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If transaccionActivo Then
            AnularTransaccion(Transac)
            transaccionActivo = False
        End If
        Me.Close()
    End Sub

    Private Sub DgvConsulta_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellContentDoubleClick
        Dim dt As New DataTable
        dt = generar_datatabla("select b.id as id, m.descripcion_materia as Materia, p.descripcion_promocion, b.ano as ano, 
         b.materia_id as materia_id, b.promocion_id as promocion_id, b.descripcion_bibliografia as Descripcion
         from bibliografia b  join materia m on m.id = b.materia_id  join promocion p on p.id = b.promocion_id 
        where b.id =  " & dgvConsulta(0, e.RowIndex).Value)

        If dt.Rows.Count > 0 Then
            nudBibliografiaID.Value = dt.Rows(0).Item("id")
            txtDescripcion.Text = dt.Rows(0).Item("Descripcion")
            cboMateria.SelectedValue = dt.Rows(0).Item("materia_id")
            cboPromocion.SelectedValue = dt.Rows(0).Item("promocion_id")
            nudAnho.Value = dt.Rows(0).Item("ano")
            RecargarGrilla()
            gbxLibro.Enabled = True
            btnHabilitarDetalle.Enabled = False
            btnEliminar.Enabled = True
            btnAgregar.Enabled = True
            btnAceptar.Enabled = True
            btnCancelar.Enabled = True
            modo = "A"
            tbcPrincipal.SelectedIndex = 0
            vNuevo = False
        End If
    End Sub

    Private Sub TbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dv = generar_datatabla("select b.id as Id, m.descripcion_materia as Materia, p.descripcion_promocion as Promocion, b.ano as Año, 
          b.descripcion_bibliografia as Descripcion
         from bibliografia b  join materia m on m.id = b.materia_id  join promocion p on p.id = b.promocion_id ").DefaultView
            dgvConsulta.DataSource = dv
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dv.RowFilter = ""
        If txtMateriaBuscar.Text.Trim <> "" Then
            dv.RowFilter = "m.descripcion_materia like '%" & txtMateriaBuscar.Text.Trim & "%'"
        End If
    End Sub
End Class