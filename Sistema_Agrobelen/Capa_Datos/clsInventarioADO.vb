Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsInventarioADO

    Public Function contarAlmacenes() As Integer
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim contador As Integer

        Try
            sql = "SELECT count(idAlmacen) FROM Almacen"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                contador = dr.GetInt32(0)
            End If
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return contador
    End Function
    Public Sub agregarInventario_PA(obj As clsInventario)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarInventario"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@idAlmacen", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@stockMinimo", SqlDbType.Int).Value = obj.stockMinimo
            cmd.Parameters.Add("@stockMaximo", SqlDbType.Int).Value = obj.stockMaximo
            cmd.Parameters.Add("@stockReal", SqlDbType.Int).Value = obj.stockReal
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Entrada_Almacen_PA(obj As clsInventario, cantidad As Integer, objKardex As clsKardex)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim objADO As New clsKardexADO
        Dim sql As String
        Try

            sql = "pa_modificarInventarioEntrada"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@idAlmacen", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = cantidad
            objKardex.stockRealRef = CInt(cmd.ExecuteScalar)
            objADO.agregarKardex_PA(objKardex)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Salida_Almacen_PA(obj As clsInventario, cantidad As Integer, objKardex As clsKardex)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim objADO As New clsKardexADO
        Dim sql As String
        Try

            sql = "pa_modificarInventarioSalida"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@idAlmacen", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = cantidad
            objKardex.stockRealRef = CInt(cmd.ExecuteScalar)
            objADO.agregarKardex_PA(objKardex)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub modificarStockInventarioEntrada_PA(obj As clsInventario, cantidad As Integer, cn As clsConexion, objKardex As clsKardex)
        Dim cmd As SqlCommand
        Dim objADO As New clsKardexADO
        Dim sql As String
        Try

            sql = "pa_modificarInventarioEntrada"
            'cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@idAlmacen", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = cantidad
            objKardex.stockRealRef = CInt(cmd.ExecuteScalar)
            objADO.agregarKardex_PA(objKardex)
            'cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub modificarStockInventarioSalida_PA(obj As clsInventario, cantidad As Integer, cn As clsConexion, objKardex As clsKardex)
        Dim cmd As SqlCommand
        Dim objADO As New clsKardexADO
        Dim sql As String
        Try

            sql = "pa_modificarInventarioSalida"
            'cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@idAlmacen", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = cantidad
            objKardex.stockRealRef = CInt(cmd.ExecuteScalar)
            objADO.agregarKardex_PA(objKardex)
            'cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub modificarDatosInventario_PA(obj As clsInventario)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarInventarioTotal"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@idAlmacen", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@stockMinimo", SqlDbType.Int).Value = obj.stockMinimo
            cmd.Parameters.Add("@stockMaximo", SqlDbType.Int).Value = obj.stockMaximo
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function buscarInventario(idProducto As Integer, idAlmacen As Integer) As clsInventario
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsInventario = Nothing

        Try
            'sql = "select * from Inventario where idProducto= '" & idProducto & "'"
            sql = "select * from Inventario where idProducto=" & idProducto & " and idAlmacen=" & idAlmacen & ""
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsInventario(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4))
            End If
            cn.Desconectar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return obj
    End Function
    Public Function buscarInventariox(idProducto As Integer) As clsInventario
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsInventario = Nothing

        Try
            sql = "select * from Inventario where idProducto= '" & idProducto & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsInventario(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4))
            End If
            cn.Desconectar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return obj
    End Function
    Public Function lstadoProductoxAlmacen(idProducto As Integer, idAlmacen As Integer) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = "select I.idProducto as ID, P.nombre,A.descripcion as SUCURSAL, I.stockReal as 'STOCK' from 
Inventario I JOIN Producto P on I.idProducto=P.idProducto JOIN Almacen A on A.idAlmacen=I.idAlmacen
 where I.idProducto=" & idProducto & " and A.idAlmacen=" & idAlmacen & ""
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
