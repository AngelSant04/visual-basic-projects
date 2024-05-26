Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsVentaADO
    Private sentencia As String = "Select V.idVenta as ID,T.serieTalonario+'-'+(REPLICATE('0',(8-LEN(O.numComprobante)))+
CONVERT(varchar(10),O.numComprobante)) as COMPROBANTE,V.fecha as 'FECHA EMISION',
C.nombres+' '+C.apPaterno+' '+C.apMaterno as CLIENTE,
(case v.estado when 1 then 'CANCELADO' when 2 then'CREDITO' when 3 then 'ANULADA' end) as 'ESTADO',
E.nombres+' '+E.apPaterno+' '+E.apMaterno as VENDEDOR
from Venta V join Cliente C on v.idCliente=c.idCliente join
Empleado E on V.idEmpleado=E.idEmpleado join Comprobante O on V.idVenta=O.idVenta join 
Talonario T on O.numTalonario=T.numTalonario"
    Public Function contarVentas(idTalonario As Integer) As Integer
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim contador As Integer

        Try
            sql = "Select count(idVenta) From Comprobante where numTalonario= " & idTalonario & ""
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            contador = CInt(cmd.ExecuteScalar())
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return contador
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
    Public Sub agregarVenta_PA(obj As clsVenta, listaDetalle As List(Of clsDetalleVenta),
                               listaInventarios As List(Of clsInventario), objKardex As clsKardex,
                               objComprobante As clsComprobante)
        Dim idVenta As Integer
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim objADO As New clsDetalleVentaADO
        Dim objCADO As New clsComprobanteADO
        Try

            sql = "pa_agregarVenta" 'Nombre de mi procedimiento almacenado
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fecha
            cmd.Parameters.Add("@formaPago", SqlDbType.Text).Value = obj.formaPago
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = obj.total
            cmd.Parameters.Add("@igv", SqlDbType.Float).Value = obj.igv
            cmd.Parameters.Add("@subtotal", SqlDbType.Float).Value = obj.subTotal
            cmd.Parameters.Add("@idCliente", SqlDbType.Text).Value = obj.idCliente
            cmd.Parameters.Add("@idEmpleado", SqlDbType.Text).Value = obj.idEmpleado
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado
            cmd.Parameters.Add("@diasCredito", SqlDbType.Int).Value = obj.diasCredito
            cmd.Parameters.Add("@fechaPago", SqlDbType.Date).Value = obj.fechaPago
            idVenta = CInt(cmd.ExecuteScalar)
            objComprobante.idVenta = idVenta
            objCADO.agregarComprobante_PA(objComprobante, cn)
            For Each objAux In listaDetalle
                objAux.idVenta = idVenta
                objADO.agregarDetalleVenta_PA(objAux, cn, listaInventarios, objKardex)
            Next
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
