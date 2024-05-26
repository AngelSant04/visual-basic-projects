Imports System.Data.SqlClient
Imports CapaEntidades
Public Class clsAsignacionADO
    Public Sub agregar_PA(obj As clsAsignacionTarea)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "pa_agregarAsignacion"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'agregar los parametros
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fechaAcceso
            cmd.Parameters.Add("@horaEntrada", SqlDbType.Time).Value = obj.horaEntrada
            cmd.Parameters.Add("@horaSalida", SqlDbType.Time).Value = obj.horaSalida
            cmd.Parameters.Add("@tareaAsignada", SqlDbType.Text).Value = obj.tareaAsignada
            cmd.Parameters.Add("@DNI", SqlDbType.Text).Value = obj.DNI
            cmd.Parameters.Add("@idArea", SqlDbType.Int).Value = obj.idArea
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub concluirTarea_PA(obj As clsAsignacionTarea)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "pa_concluirAsignacion"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'agregar los parametros
            cmd.Parameters.Add("@horaSalida", SqlDbType.Time).Value = obj.horaSalida
            cmd.Parameters.Add("@idAsignacion", SqlDbType.Int).Value = obj.idAsignacion
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function verificarTareaPorConcluir(dni As String, fecha As Date) As clsAsignacionTarea
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsAsignacionTarea = Nothing

        Try
            sql = "select * from AsignacionTarea where DNI = '" & dni &
                "' and fechaAcceso = '" & fecha & "' and estado = 1"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsAsignacionTarea(dr.GetInt32(0), dr.GetDateTime(1),
                            dr.GetTimeSpan(2), dr.GetTimeSpan(3), dr.GetString(4),
                            dr.GetString(5), dr.GetInt32(6), dr.GetInt32(7))
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
End Class
