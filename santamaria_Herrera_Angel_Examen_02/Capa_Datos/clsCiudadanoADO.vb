Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsCiudadanoADO
    Public Function buscarCiudadano(DNIAux As String) As clsCiudadano
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsCiudadano = Nothing

        Try
            sql = "select * from Ciudadano where DNI = '" & DNIAux & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsCiudadano(dr.GetString(0), dr.GetString(1), dr.GetString(2),
                                     dr.GetString(3), dr.GetDateTime(4), dr.GetInt32(5))
            End If
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
End Class
