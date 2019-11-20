Imports System.Data.SqlClient
Public Class bibliografia
    Dim Transac As SqlTransaction
    Dim BibliografiaID As Integer
    Dim vLibro As Integer
    Private Sub bibliografia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        EjecutarSQL("Insert into bibliografia values(@1,@2,@3)", Transac, cboMateria.SelectedValue, cboPromocion.SelectedValue, nudAnho.Value)

        gbxLibro.Enabled = True
        btnHabilitarDetalle.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        cboLibro.Focus()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If cboLibro.Text = "" Then
                cboLibro.Focus()
                MsgBox("Debe seleccionar un Libro.")
                Exit Sub
            End If

            BibliografiaID = TraerValor("select max(id) from bibliografia", Transac)
            EjecutarSQL("insert into detalle_bibliografia values (@1,@2,@3)", Transac, BibliografiaID, cboLibro.SelectedValue, txtDescripcion.Text)
            ActualizarGrilla()



            cboLibro.SelectedValue = -1
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MessageBox.Show("¿Está seguro de confirmar la Bibliografia?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ConfirmarTransaccion(Transac)
            LimpiarFormulario()
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
            LimpiarFormulario()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Está seguro de eliminar el Libro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Try

                EjecutarSQL("delete from detalle_bibliografia where id = @1 AND libro_id = @2", Transac, BibliografiaID, vLibro)
                ActualizarGrilla()



            Catch ex As Exception
                MessageBox.Show("Error al momento de eliminar Libro" & vbNewLine & ex.Message())
                AnularTransaccion(Transac)
            End Try

        End If
    End Sub

    Private Sub dgvDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellClick
        Dim row As DataGridViewRow
        row = dgvDetalle.CurrentRow
        vLibro = row.Cells("Id").Value
    End Sub
End Class