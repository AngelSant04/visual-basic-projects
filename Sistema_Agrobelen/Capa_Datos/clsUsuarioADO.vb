Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsUsuarioADO
    Public Sub agregarUsuario_PA(obj As clsUsuario)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarUsuario"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idEmpleado", SqlDbType.Text).Value = obj.idEmpleado
            cmd.Parameters.Add("@clave", SqlDbType.Text).Value = obj.clave
            cmd.Parameters.Add("@idCategoriaUsuario", SqlDbType.Int).Value = obj.idCategoriaUsuario
            cmd.Parameters.Add("@estado", SqlDbType.Text).Value = obj.estado
            cmd.Parameters.Add("@idUsuario", SqlDbType.Text).Value = obj.idUsuario
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub modificarUsuario_PA(obj As clsUsuario)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarUsuario"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idEmpleado", SqlDbType.Text).Value = obj.idEmpleado
            cmd.Parameters.Add("@clave", SqlDbType.Text).Value = obj.clave
            cmd.Parameters.Add("@idCategoriaUsuario", SqlDbType.Int).Value = obj.idCategoriaUsuario
            cmd.Parameters.Add("@estado", SqlDbType.Text).Value = obj.estado
            cmd.Parameters.Add("@idUsuario", SqlDbType.Text).Value = obj.idUsuario
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function buscarUsuario(usuario As String, clave As String) As clsUsuario
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsUsuario = Nothing

        Try
            sql = "select * from Usuario where idUsuario = '" & usuario & "' 
	               and clave = '" & clave & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsUsuario(dr.GetString(0), dr.GetString(1), dr.GetInt32(2),
                                     dr.GetString(3), dr.GetString(4))
            End If
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
    Public Function buscarUsuarioXempleado(idEmpleado As String) As clsUsuario
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsUsuario = Nothing

        Try
            sql = "select * from Usuario where idEmpleado = '" & idEmpleado & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsUsuario(dr.GetString(0), dr.GetString(1), dr.GetInt32(2),
                                     dr.GetString(3), dr.GetString(4))
            End If
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
    Public Function listado() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            da = New SqlDataAdapter("Select * from Usuario", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
