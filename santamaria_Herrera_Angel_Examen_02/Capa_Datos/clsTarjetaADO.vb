Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsTarjetaADO
    Public Sub agregarTarjeta_PA(obj As clsTarjetaVacuna)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarTarjeta"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@DNI", SqlDbType.Text).Value = obj.DNI
            cmd.Parameters.Add("@dosis", SqlDbType.Int).Value = obj.numDosis
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fecha
            cmd.Parameters.Add("@idVacuna", SqlDbType.Int).Value = obj.idVacuna
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub modificarDosisTarjeta_PA(DNIAux As String)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarDosisTarjeta"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@DNI", SqlDbType.Text).Value = DNIAux
            cmd.Parameters.Add("@dosis", SqlDbType.Int).Value = 2
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
            da = New SqlDataAdapter("select * from Tarjeta_Vacunacion", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function buscarTarjeta(DNIAux As String) As clsTarjetaVacuna
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsTarjetaVacuna = Nothing

        Try
            sql = "select * from Tarjeta_Vacunacion where DNI = '" & DNIAux & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsTarjetaVacuna(dr.GetString(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetInt32(3))
            End If
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
End Class
