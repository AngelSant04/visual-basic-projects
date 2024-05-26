Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsCategoriaUsuarioADO
    Public Sub agregarCategoriaUsuario_PA(obj As clsCategoriaUsuario)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarCategoriaUsuario"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = obj.descripcion
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub modificarCategoriaUsuario_PA(obj As clsCategoriaUsuario)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarCategoriaUsuario"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = obj.idCategoriaUsuario
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = obj.descripcion
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
            da = New SqlDataAdapter("Select * from Categoria_Usuario", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
