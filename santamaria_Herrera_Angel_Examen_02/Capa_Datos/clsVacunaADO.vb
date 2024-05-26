Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsVacunaADO
    Public Sub agregarVacuna_PA(obj As clsVacuna)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarVacuna"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@empresa", SqlDbType.Text).Value = obj.empresa
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = obj.cantidad
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fecha
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function listado() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            da = New SqlDataAdapter("Select * from Vacunas", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
