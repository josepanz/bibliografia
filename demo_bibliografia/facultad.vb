﻿Imports System.Data.SqlClient
Public Class frmFacultad
    'frmFacultad
    Dim dvFacultad As New DataView
    Dim vNuevo As Boolean = True
    Private Sub LimpiarFormulario()
        nudFacultadID.Value = 0
        txtCodeFacultad.Clear()
        txtFacultad.Clear()
        vNuevo = True
    End Sub
    Function DatosValidos()
        If txtCodeFacultad.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar la Codigo Facultad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodeFacultad.Focus()
            Return False
        End If
        If txtFacultad.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar Facultad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFacultad.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If vNuevo = False Then
            If MessageBox.Show("¿Está seguro de eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EjecutarSQL("delete from facultad WHERE id =@1", nudFacultadID.Value)
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
                EjecutarSQL("update facultad set nombre_facultad=@1,codigo_facultad=@2 where id=@3", txtFacultad.Text.Trim, txtCodeFacultad.Text.Trim, nudFacultadID.Value)
            Else
                EjecutarSQL("insert into facultad values(@1,@2)", txtFacultad.Text.Trim, txtCodeFacultad.Text.Trim)
            End If
            MessageBox.Show("Registro guardado con éxito")
            LimpiarFormulario()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dvFacultad.RowFilter = ""
        If txtFacultadBuscar.Text.Trim <> "" Then
            dvFacultad.RowFilter = "Facultad like '%" & txtFacultadBuscar.Text.Trim & "%'"
        End If
    End Sub

    Private Sub tbcFacultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dvFacultad = generar_datatabla("SELECT id as Id, codigo_facultad as Codigo, nombre_facultad as Facultad  FROM facultad").DefaultView
            dgvConsulta.DataSource = dvFacultad
        End If
    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        Dim dtFacultad As New DataTable
        dtFacultad = generar_datatabla("select * from facultad where id = " & dgvConsulta(0, e.RowIndex).Value)

        If dtFacultad.Rows.Count > 0 Then
            nudFacultadID.Value = dtFacultad.Rows(0).Item("id")
            txtFacultad.Text = dtFacultad.Rows(0).Item("nombre_facultad")
            txtCodeFacultad.Text = dtFacultad.Rows(0).Item("codigo_facultad")
            tbcPrincipal.SelectedIndex = 0
            vNuevo = False
        End If
    End Sub
End Class
