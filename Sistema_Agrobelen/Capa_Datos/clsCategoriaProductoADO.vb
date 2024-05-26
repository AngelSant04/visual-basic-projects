Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsCategoriaProductoADO
    Private sentencia As String = "select C.idCategoria AS ID, C.descripcion AS 'TIPO' from Categoria_Producto C"
    Public Sub agregarCategoriaProducto_PA(obj As clsCategoriaProducto)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarCategoriaProducto"
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
    Public Sub modificarCategoriaProducto_PA(obj As clsCategoriaProducto)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarCategoriaProducto"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.idCategoria
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = obj.descripcion
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function listadoCompleto() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            da = New SqlDataAdapter(sentencia, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listado() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            da = New SqlDataAdapter("select * from Categoria_Producto", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
