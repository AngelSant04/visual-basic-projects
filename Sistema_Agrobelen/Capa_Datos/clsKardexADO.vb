Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsKardexADO
    Public Sub agregarKardex_PA(obj As clsKardex)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarKardex"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fecha
            cmd.Parameters.Add("@tipoMovimiento", SqlDbType.Text).Value = obj.tipoMovimiento
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = obj.descripcion
            cmd.Parameters.Add("@sucurRef", SqlDbType.Text).Value = obj.sucursalRef
            cmd.Parameters.Add("@stockRef", SqlDbType.Int).Value = obj.stockRealRef
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.Parameters.Add("@idAlmacen", SqlDbType.Int).Value = obj.idAlmacen
            cmd.Parameters.Add("@docRef", SqlDbType.Text).Value = obj.docRef
            cmd.Parameters.Add("@responsable", SqlDbType.Text).Value = obj.responsable
            cmd.Parameters.Add("@destino", SqlDbType.Text).Value = obj.destino
            cmd.Parameters.Add("@precioRef", SqlDbType.Float).Value = obj.precioRef
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function contarKardex(tipoMovimiento As String) As Integer
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim contador As Integer

        Try
            sql = "Select count(idKardex) From Kardex where tipoMovimiento= '" & tipoMovimiento & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            contador = CInt(cmd.ExecuteScalar())
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return contador
    End Function
    Public Function KardexProducto(idAlmacen As Integer, idProducto As Integer) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim sql As String
        Try
            cn.Conectar()
            sql = "select K.idKardex as 'ID', K.fecha as 'FECHA EMISION',K.docReferencia as 'DOCUMENTO',
             K.responsable as 'RESPONSABLE', K.tipoMovimiento as 'TIPO MOVIMIENTO', 
             K.descripcion as 'DESCRIPCION',P.nombre as 'NOMBRE PRODUCTO', k.destino as 'DESTINO', 
             K.stockRef as 'STOCK',K.sucursalRef as 'SUCURSAL'from Kardex K join Producto P on 
             K.idProducto = P.idProducto where K.idAlmacen =" & idAlmacen & "
             and K.idProducto = " & idProducto & " order by K.tipoMovimiento"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
