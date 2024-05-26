Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsDetalleVentaADO
    Public Sub agregarDetalleVenta_PA(obj As clsDetalleVenta, cn As clsConexion, listaInventarios As List(Of clsInventario), objKardex As clsKardex)
        Dim cmd As SqlCommand
        Dim sql As String
        Dim objADO As New clsInventarioADO
        Dim objProducto As clsProducto
        Dim objProductoADO As New clsProductoADO
        Try

            sql = "pa_agregarDetalleVenta" 'Nombre de mi procedimiento almacenado
            'cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = obj.Cantidad
            cmd.Parameters.Add("@subtotal", SqlDbType.Float).Value = obj.Subtotal
            cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = obj.idVenta
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.idProducto
            cmd.ExecuteNonQuery()
            For Each objAux In listaInventarios
                If objAux.idProducto = obj.idProducto Then 'Para que producto por producto me modifique inventario
                    objKardex.idProducto = obj.idProducto
                    objProducto = objProductoADO.buscarProducto(obj.idProducto)
                    objKardex.precioRef = objProducto.precio
                    objADO.modificarStockInventarioSalida_PA(objAux, obj.Cantidad, cn, objKardex)
                End If
            Next
            'cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
