Imports System.Data.SqlClient
Public Class promocion
    Dim dv As New DataView
    Dim vNuevo As Boolean = True
    Private Sub LimpiarFormulario()
        nudPromocionID.Value = 0
        txtPromo.Clear()
        nudAnho.Value = 0
        nudNroPromo.Value = 0
        vNuevo = True
    End Sub
    Function DatosValidos()
        If txtPromo.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar descripcion Promo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPromo.Focus()
            Return False
        End If
        If nudAnho.Value = 0 Then
            MessageBox.Show("Debe ingresar Anho", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudAnho.Focus()
            Return False
        End If
        If nudNroPromo.Value = 0 Then
            MessageBox.Show("Debe ingresar Promo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudNroPromo.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If vNuevo = False Then
            If MessageBox.Show("¿Está seguro de eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EjecutarSQL("delete from promocion WHERE id =@1", nudPromocionID.Value)
                MessageBox.Show("Registro eliminado con éxito")
                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If DatosValidos() = True Then
            If vNuevo = False Then
                EjecutarSQL("update promocion set descripcion_promocion=@1,ano_promocion=@2,nro_promocion=@3 where id =@4", txtPromo.Text, nudAnho.Value, nudNroPromo.Value, nudPromocionID.Value)
            Else
                EjecutarSQL("insert into promocion values(@1,@2,@3)", txtPromo.Text, nudAnho.Value, nudNroPromo.Value)
            End If
            MessageBox.Show("Registro guardado con éxito")
            LimpiarFormulario()
        End If
    End Sub

    Private Sub tbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dv = generar_datatabla("select id as Id,descripcion_promocion as Descripcion, ano_promocion as AnhoPromocion, nro_promocion as NroPromocion from promocion").DefaultView
            dgvConsulta.DataSource = dv
        End If
    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        Dim dt As New DataTable
        dt = generar_datatabla("select * from promocion where id = " & dgvConsulta(0, e.RowIndex).Value)

        If dt.Rows.Count > 0 Then
            nudPromocionID.Value = dt.Rows(0).Item("id")
            txtPromo.Text = dt.Rows(0).Item("descripcion_promocion")
            nudAnho.Value = dt.Rows(0).Item("ano_promocion")
            nudNroPromo.Value = dt.Rows(0).Item("nro_promocion")
            tbcPrincipal.SelectedIndex = 0
            vNuevo = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dv.RowFilter = ""
        If txtBuscar.Text.Trim <> "" Then
            dv.RowFilter = "Descripcion like '%" & txtBuscar.Text.Trim & "%'"
        End If
    End Sub
End Class