Imports System.Data.SqlClient
Public Class autor
    Dim dv As New DataView
    Dim vNuevo As Boolean = True
    Private Sub LimpiarFormulario()
        nudAutorID.Value = 0
        txtAutor.Clear()
        vNuevo = True
    End Sub
    Function DatosValidos()
        If txtAutor.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar Nombre y Apellido del Autor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAutor.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If vNuevo = False Then
            If MessageBox.Show("¿Está seguro de eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EjecutarSQL("delete from autor WHERE id = @1", nudAutorID.Value)
                MessageBox.Show("Registro eliminado con éxito")
                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If DatosValidos() = True Then
            Dim vComando As New SqlCommand
            vComando.Connection = conexion
            If vNuevo = False Then
                EjecutarSQL("update autor Set nombre_autor=@1 where id=@2", txtAutor.Text, nudAutorID.Value)
            Else
                EjecutarSQL("insert into autor values(@1)", txtAutor.Text.Trim)
            End If
            MessageBox.Show("Registro guardado con éxito")
            LimpiarFormulario()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dv.RowFilter = ""
        If txtBuscar.Text.Trim <> "" Then
            dv.RowFilter = "Nombre Like '%" & txtBuscar.Text.Trim & "%'"
        End If
    End Sub

    Private Sub tbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dv = generar_datatabla("SELECT id as Id, nombre_autor as Nombre FROM autor").DefaultView
            dgvConsulta.DataSource = dv
        End If
    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        Dim dtFacultad As New DataTable
        dtFacultad = generar_datatabla("select * from autor where id = " & dgvConsulta(0, e.RowIndex).Value)

        If dtFacultad.Rows.Count > 0 Then
            nudAutorID.Value = dtFacultad.Rows(0).Item("id")
            txtAutor.Text = dtFacultad.Rows(0).Item("nombre_autor")
            tbcPrincipal.SelectedIndex = 0
            vNuevo = False
        End If
    End Sub


End Class