Imports System.Data.SqlClient
Public Class frmMateria
    Public conexion As New SqlConnection("data source=DESKTOP-B2NQHEC;initial catalog=bibliografia;uid=sa;pwd=juncris")
    Dim dvMateria As New DataView
    Dim vNuevo As Boolean = True
    Private Sub LimpiarFormulario()
        nudMateriaID.Value = 0
        txtCodeMateria.Clear()
        txtMateria.Clear()
        cboFacultad.SelectedIndex = -1
        vNuevo = True
    End Sub
    Function DatosValidos()
        If txtCodeMateria.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar  Codigo Materia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodeMateria.Focus()
            Return False
        End If
        If txtMateria.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar Materia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMateria.Focus()
            Return False
        End If
        If cboFacultad.SelectedIndex = -1 Then
            MessageBox.Show("Debe Seleccionar Facultad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboFacultad.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub frmMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cboFacultad
            .DisplayMember = "nombre_facultad"
            .ValueMember = "id"
            .DataSource = generar_datatabla("select * from facultad")
            cboFacultad.SelectedIndex = -1
        End With
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If vNuevo = False Then
            If MessageBox.Show("¿Está seguro de eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim vComando As New SqlCommand("delete from materia WHERE id = " & nudMateriaID.Value, conexion)
                conexion.Open()
                vComando.ExecuteNonQuery()
                conexion.Close()
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
                vComando.CommandText = "update materia set codigo_materia='" & txtCodeMateria.Text & "',descripcion_materia='" & txtMateria.Text & "',facultad_id=" & cboFacultad.SelectedValue & " where id = " & nudMateriaID.Value
            Else
                vComando.CommandText = "insert into materia values('" & txtCodeMateria.Text & "','" & txtMateria.Text & "','" & cboFacultad.SelectedValue & "')"
            End If
            conexion.Open()
            vComando.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Registro guardado con éxito")
            LimpiarFormulario()
        End If
    End Sub
    Private Sub tbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dvMateria = generar_datatabla("select m.id as Id, m.codigo_materia as Codigo, m.descripcion_materia as Materia, f.nombre_facultad as Facultad  from materia m join facultad f on f.id = m.facultad_id").DefaultView
            dgvConsulta.DataSource = dvMateria
        End If
    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        Dim dtMateria As New DataTable
        dtMateria = generar_datatabla("select * from materia where id = " & dgvConsulta(0, e.RowIndex).Value)

        If dtMateria.Rows.Count > 0 Then
            nudMateriaID.Value = dtMateria.Rows(0).Item("id")
            txtCodeMateria.Text = dtMateria.Rows(0).Item("codigo_materia")
            txtMateria.Text = dtMateria.Rows(0).Item("descripcion_materia")
            cboFacultad.SelectedValue = dtMateria.Rows(0).Item("facultad_id")
            tbcPrincipal.SelectedIndex = 0
            vNuevo = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dvMateria.RowFilter = ""
        If txtMateriaBuscar.Text.Trim <> "" Then
            dvMateria.RowFilter = "Materia like '%" & txtMateriaBuscar.Text.Trim & "%'"
        End If
    End Sub
End Class