Imports System.Data.SqlClient
Public Class libro
    Dim dv As New DataView
    Dim vNuevo As Boolean = True
    Private Sub LimpiarFormulario()
        nudLibroID.Value = 0
        txtIbsn.Clear()
        txtTitulo.Clear()
        cboEdicion.SelectedIndex = -1
        cboEditorial.SelectedIndex = -1
        cboAutor.SelectedIndex = -1
        nudAnho.Value = 0
        vNuevo = True
    End Sub
    Function DatosValidos()
        If txtIbsn.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar IBSN", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIbsn.Focus()
            Return False
        End If
        If txtTitulo.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar Titulo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTitulo.Focus()
            Return False
        End If
        If cboEdicion.SelectedIndex = -1 Then
            MessageBox.Show("Debe Seleccionar Edicion", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEdicion.Focus()
            Return False
        End If
        If cboEditorial.SelectedIndex = -1 Then
            MessageBox.Show("Debe Seleccionar Editorial", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEdicion.Focus()
            Return False
        End If
        If cboAutor.SelectedIndex = -1 Then
            MessageBox.Show("Debe Seleccionar Autor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEdicion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub libro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cboEdicion
            .DisplayMember = "descripcion"
            .ValueMember = "id"
            .DataSource = generar_datatabla("select * from edicion")
            cboEdicion.SelectedIndex = -1
        End With
        With cboEditorial
            .DisplayMember = "nombre_editorial"
            .ValueMember = "id"
            .DataSource = generar_datatabla("select * from editorial")
            cboEditorial.SelectedIndex = -1
        End With
        With cboAutor
            .DisplayMember = "nombre_autor"
            .ValueMember = "id"
            .DataSource = generar_datatabla("select * from autor")
            cboAutor.SelectedIndex = -1
        End With
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If vNuevo = False Then
            If MessageBox.Show("¿Está seguro de eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EjecutarSQL("delete from libro WHERE id =@1 ", nudLibroID.Value)
                MessageBox.Show("Registro eliminado con éxito")
                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If DatosValidos() = True Then
            If vNuevo = False Then
                EjecutarSQL("update libro set isbn=@1,titulo=@2,edicion_id=@3, editorial_id =@4, autor_id =@5, ano_publicacion =@6  where id = @7", txtIbsn.Text, txtTitulo.Text, cboEdicion.SelectedValue, cboEditorial.SelectedValue, cboAutor.SelectedValue, nudAnho.Value, nudLibroID.Value)
            Else
                EjecutarSQL("insert into libro values(@1,@2,@3,@4,@5,@6)", txtIbsn.Text, txtTitulo.Text, cboEdicion.SelectedValue, cboEditorial.SelectedValue, cboAutor.SelectedValue, nudAnho.Value)
            End If
            MessageBox.Show("Registro guardado con éxito")
            LimpiarFormulario()
        End If
    End Sub

    Private Sub tbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dv = generar_datatabla("SELECT l.id as Id,l.isbn as Isbn,l.titulo as Titulo
            ,e.descripcion as Edicion,ed.nombre_editorial as Editorial, autor.nombre_autor as Autor,ano_publicacion as AnhoPublicacion
             from libro l join edicion e on e.id=l.edicion_id 
             join editorial ed on ed.id=l.editorial_id
             join autor autor on autor.id=l.autor_id").DefaultView
            dgvConsulta.DataSource = dv
        End If
    End Sub

    Private Sub dgvConsulta_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellContentDoubleClick
        Dim dt As New DataTable
        dt = generar_datatabla("select * from libro where id = " & dgvConsulta(0, e.RowIndex).Value)

        If dt.Rows.Count > 0 Then
            nudLibroID.Value = dt.Rows(0).Item("id")
            txtIbsn.Text = dt.Rows(0).Item("isbn")
            txtTitulo.Text = dt.Rows(0).Item("titulo")
            cboEdicion.SelectedValue = dt.Rows(0).Item("edicion_id")
            cboEditorial.SelectedValue = dt.Rows(0).Item("editorial_id")
            cboAutor.SelectedValue = dt.Rows(0).Item("autor_id")
            nudAnho.Value = dt.Rows(0).Item("ano_publicacion")
            tbcPrincipal.SelectedIndex = 0
            vNuevo = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dv.RowFilter = ""
        If txtMateriaBuscar.Text.Trim <> "" Then
            dv.RowFilter = "Titulo like '%" & txtMateriaBuscar.Text.Trim & "%'"
        End If
    End Sub
End Class