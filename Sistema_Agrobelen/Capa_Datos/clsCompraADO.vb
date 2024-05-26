Imports Capa_Entidades
Imports System.Data.SqlClient

Public Class clsCompraADO
    Private sentencia As String = "select C.idCompra AS 'ID COMPRA',C.idProveedor AS 'ID PROVEEDOR',P.nombre AS 'NOMBRE PROVEEDOR', C.fecha AS 'FECHA COMPRA', 
            C.total AS 'TOTAL' from Compra C join Proveedor P on C.idProveedor=P.idProveedor"
    Public Sub agregarCompra_PA(obj As clsCompra, listaDetalle As List(Of clsDetalleCompra), listaInventarios As List(Of clsInventario), objKardex As clsKardex)
        Dim idCompra As Integer
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim objADO As New clsDetalleCompraADO
        Try

            sql = "pa_agregarCompra" 'Nombre de mi procedimiento almacenado
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fecha
            cmd.Parameters.Add("@formaPago", SqlDbType.Text).Value = obj.formaPago
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = obj.total
            cmd.Parameters.Add("@igv", SqlDbType.Float).Value = obj.igv
            cmd.Parameters.Add("@numCompra", SqlDbType.Text).Value = obj.numCompra
            cmd.Parameters.Add("@serieCompra", SqlDbType.Text).Value = obj.serieCompra
            cmd.Parameters.Add("@subtotal", SqlDbType.Float).Value = obj.subTotal
            cmd.Parameters.Add("@tipoComprobante", SqlDbType.Text).Value = obj.tipoComprobante
            cmd.Parameters.Add("@diasCredito", SqlDbType.Int).Value = obj.diasCredito
            cmd.Parameters.Add("@fechaPago", SqlDbType.Date).Value = obj.fechaPago
            cmd.Parameters.Add("@idProveedor", SqlDbType.Text).Value = obj.idProveedor
            cmd.Parameters.Add("@idEmpleado", SqlDbType.Text).Value = obj.idEmpleado
            cmd.Parameters.Add("@idUsuario", SqlDbType.Text).Value = obj.idUsuario
            idCompra = CInt(cmd.ExecuteScalar)
            For Each objAux In listaDetalle
                objAux.idCompra = idCompra
                objADO.agregarDetalleCompra_PA(objAux, cn, listaInventarios, objKardex)
            Next
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub modificarCompra_PA(obj As clsCompra)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarCompra" 'Nombre de mi procedimiento almacenado
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idCompra", SqlDbType.Int).Value = obj.idCompra
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fecha
            cmd.Parameters.Add("@formaPago", SqlDbType.Text).Value = obj.formaPago
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = obj.total
            cmd.Parameters.Add("@igv", SqlDbType.Float).Value = obj.igv
            cmd.Parameters.Add("@numCompra", SqlDbType.Text).Value = obj.numCompra
            cmd.Parameters.Add("@serieCompra", SqlDbType.Text).Value = obj.serieCompra
            cmd.Parameters.Add("@subtotal", SqlDbType.Float).Value = obj.subTotal
            cmd.Parameters.Add("@tipoComprobante", SqlDbType.Text).Value = obj.tipoComprobante
            cmd.Parameters.Add("@diasCredito", SqlDbType.Int).Value = obj.diasCredito
            cmd.Parameters.Add("@fechaPago", SqlDbType.Date).Value = obj.fechaPago
            cmd.Parameters.Add("@idProveedor", SqlDbType.Text).Value = obj.idProveedor
            cmd.Parameters.Add("@idEmpleado", SqlDbType.Text).Value = obj.idEmpleado
            cmd.Parameters.Add("@idUsuario", SqlDbType.Text).Value = obj.idUsuario
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
    Public Function listadoXletra(texto) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia & " where P.idProveedor like '" & texto & "%'"
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
    Public Function listadoXFechas(fechaInicio As Date, fechaFinal As Date) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia & " where C.fecha < '" & fechaFinal & "' and C.fecha > '" & fechaInicio & "'"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
