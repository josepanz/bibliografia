Imports System.Data.SqlClient
Module acceso_datos
    Public conexion As New SqlConnection("data source=OZUNA;initial catalog=bibliografia;uid=sa;pwd=asdasdx2")
    'Public conexion As New SqlConnection("data source=JPANZA\SQLSERVER;initial catalog=bibliografia;Integrated Security=True")
    Public Function generar_datatabla(comando_sql As String) As DataTable
        Dim tabla As New DataTable
        Try
            Dim cmd As New SqlCommand(comando_sql, conexion)
            Dim adaptador As New SqlDataAdapter(cmd)
            adaptador.Fill(tabla) 'h'
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function generar_datatabla(comando_sql As String, ByRef dbtransac As SqlTransaction) As DataTable
        Dim tabla As New DataTable
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Dim cmd As New SqlCommand(comando_sql, conexion, dbtransac)
            Dim adaptador As New SqlDataAdapter(cmd)
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub EjecutarSQL(comando_sql As String, ParamArray Arrayparametros() As Object)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Dim cmd As New SqlCommand(comando_sql, conexion)
            For i As Integer = 1 To Arrayparametros.Length
                cmd.Parameters.AddWithValue("@" & i.ToString, Arrayparametros(i - 1))
            Next
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub EjecutarSQL(instruccion_SQL As String, ByRef dbtransac As SqlTransaction, ParamArray parametros() As Object)
        Try
            Dim comando As New SqlCommand(instruccion_SQL, conexion, dbtransac)
            For i As Integer = 1 To parametros.Length
                comando.Parameters.AddWithValue("@" & i.ToString(), parametros(i - 1))
            Next
            comando.ExecuteNonQuery()
        Catch ex As Exception
            AnularTransaccion(dbtransac)
            Throw ex
        End Try
    End Sub
    Public Function IniciarTransaccion() As SqlTransaction
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Return conexion.BeginTransaction
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub AnularTransaccion(ByRef dbt As SqlTransaction)
        Try
            dbt.Rollback()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ConfirmarTransaccion(ByRef dbt As SqlTransaction)
        Try
            'Confirmar la transacción
            dbt.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function TraerValor(comando_sql As String) As Object
        Try
            Dim cmd As New SqlCommand(comando_sql, conexion)
            Return cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function TraerValor(instruccionSQL As String, ByRef dbtransac As SqlTransaction) As Object
        Try
            Dim UAA As New SqlCommand(instruccionSQL, conexion, dbtransac)
            'ExecuteScalar retorna el valor de la primera celda devuelta por la consulta.
            Return UAA.ExecuteScalar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Module