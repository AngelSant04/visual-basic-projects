Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsProductoADO
    'Dim sentencia As String = "select I.idProducto AS 'ID PRODUCTO' ,I.idAlmacen AS 'ID ALMACEN' , A.sucursal as 'SUCURSAL',
    '                        P.nombre as 'NOMBRE',(case P.estado when 1 then 'ACTIVO' when 2 then'INACTIVO' end) as 'ESTADO', P.precio as 'PRECIO', P.costo as 'COSTO',
    '                        PO.idProveedor as 'ID PROVEEDOR', PO.nombre as 'NOMBRE PROVEEDOR',
    '                        CP.descripcion as DESCRIPCION, I.stockMinimo as 'STOCK MINIMO', I.stockMaximo as 'STOCK MAXIMO' from Producto P JOIN Inventario I on I.idProducto = P.idProducto JOIN Almacen A on I.idAlmacen=A.idAlmacen
    '                        JOIN Categoria_Producto CP on P.idCategoria = CP.idCategoria
    '                        JOIN Proveedor PO on P.idProveedor = PO.idProveedor"
    Dim sentencia As String = "select P.idProducto AS ID ,P.nombre AS 'NOMBRE' ,
(case P.estado when 1 then 'ACTIVO' when 2 then'INACTIVO' end) as 'ESTADO', P.precio as 'PRECIO', P.costo as 'COSTO',
PO.idProveedor as 'ID PROVEEDOR', PO.nombre as 'NOMBRE PROVEEDOR',
CP.descripcion as 'CATEGORIA PRODUCTO' from Producto P JOIN Categoria_Producto CP on P.idCategoria = CP.idCategoria
JOIN Proveedor PO on P.idProveedor = PO.idProveedor "
    Dim sentencia2 As String = "select P.idProducto AS ID_PRODUCTO,P.nombre as NOMBRE,P.costo as COSTO,I.stockReal as 'STOCK DISPONIBLE' from Producto P JOIN Inventario 
I ON P.idProducto=I.idProducto where I.idAlmacen="
    Public Function agregarProducto_PA(obj As clsProducto) As Integer
        Dim aux As Integer
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarProducto" 'Nombre de mi procedimiento almacenado
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@nombre", SqlDbType.Text).Value = obj.nombre
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado
            cmd.Parameters.Add("@precio", SqlDbType.Float).Value = obj.precio
            cmd.Parameters.Add("@costo", SqlDbType.Float).Value = obj.costo
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = obj.idCategoria
            cmd.Parameters.Add("@idProveedor", SqlDbType.Text).Value = obj.idProveedor
            aux = CInt(cmd.ExecuteScalar)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return aux
    End Function
    Public Function buscarProducto(idProducto As Integer) As clsProducto
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsProducto = Nothing

        Try
            sql = "select * from Producto where idProducto= '" & idProducto & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsProducto(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetDouble(3), dr.GetDouble(4), dr.GetInt32(5), dr.GetString(6))
            End If
            cn.Desconectar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return obj
    End Function
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
    Public Function listadoXAlmacen(idAlmacen As Integer) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim sql As String
        Try
            cn.Conectar()
            sql = "select I.idProducto AS 'ID PRODUCTO' ,I.idAlmacen AS 'ID ALMACEN' , A.sucursal as 'SUCURSAL',
                            P.nombre as 'NOMBRE',(case P.estado when 1 then 'ACTIVO' when 2 then'INACTIVO' end) as 'ESTADO', P.precio as 'PRECIO', P.costo as 'COSTO',
                            PO.idProveedor as 'ID PROVEEDOR', PO.nombre as 'NOMBRE PROVEEDOR',
                            CP.descripcion as DESCRIPCION, I.stockMinimo as 'STOCK MINIMO', I.stockMaximo as 'STOCK MAXIMO' from Producto P JOIN Inventario I on I.idProducto = P.idProducto JOIN Almacen A on I.idAlmacen=A.idAlmacen
                            JOIN Categoria_Producto CP on P.idCategoria = CP.idCategoria
                            JOIN Proveedor PO on P.idProveedor = PO.idProveedor where I.idAlmacen = " & idAlmacen & ""
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Sub modificarProducto_PA(obj As clsProducto)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarProducto"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@nombre", SqlDbType.Text).Value = obj.nombre
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado
            cmd.Parameters.Add("@precio", SqlDbType.Float).Value = obj.precio
            cmd.Parameters.Add("@costo", SqlDbType.Float).Value = obj.costo
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = obj.idCategoria
            cmd.Parameters.Add("@idProveedor", SqlDbType.Text).Value = obj.idProveedor
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function listadoXletra(texto) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia & " where P.idProducto like " & CInt(texto) & ""
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadoXnombre(texto) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia & " where P.nombre like '" & texto & "%'"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadoXnombreVenta(idAlmacen As Integer, texto As String) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia2 & idAlmacen & "AND P.nombre like '" & texto & "%'"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadoXletraVenta(idAlmacen As Integer, texto As String) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            ' 1 AND P.nombre like 'CI%'
            sql = sentencia2 & idAlmacen & "AND P.idProducto like " & CInt(texto) & ""
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadoProductoVenta(idAlmacen As Integer) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia2 & idAlmacen & ""
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
