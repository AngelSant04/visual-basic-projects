Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsAlmacenADO
    Private sentencia As String = "select A.idAlmacen AS ID,A.sucursal AS 'SUCURSAL',A.descripcion AS 'UBICACION' from Almacen A"

    'aqui van las sentencias sql (insert , update, select)
    Public Sub agregarAlmacen_PA(obj As clsAlmacen)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarAlmacen"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@sucursal", SqlDbType.Text).Value = obj.sucursal
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = obj.descripcion
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificarAlmacen_PA(obj As clsAlmacen)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarAlmacen"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@sucursal", SqlDbType.Text).Value = obj.sucursal
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
            da = New SqlDataAdapter(sentencia, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadoCombo() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            da = New SqlDataAdapter("select * from Almacen", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

End Class
