Public Class clsCompra
    Property idCompra As Integer
    Property fecha As Date
    Property formaPago As String
    Property total As Double
    Property igv As Double
    Property numCompra As String
    Property serieCompra As String
    Property subTotal As Double
    Property tipoComprobante As String
    Property diasCredito As Integer
    Property fechaPago As Date
    Property idProveedor As String
    Property idEmpleado As String
    Property idUsuario As String
    Public Sub New(idCompra As Integer, fecha As Date, formaPago As String, total As Double, igv As Double, numCompra As String, serieCompra As String, subTotal As Double, tipoComprobante As String, diasCredito As Integer, fechaPago As Date, idProveedor As String, idEmpleado As String, idUsuario As String)
        Me.idCompra = idCompra
        Me.fecha = fecha
        Me.formaPago = formaPago
        Me.total = total
        Me.igv = igv
        Me.numCompra = numCompra
        Me.serieCompra = serieCompra
        Me.subTotal = subTotal
        Me.tipoComprobante = tipoComprobante
        Me.diasCredito = diasCredito
        Me.fechaPago = fechaPago
        Me.idProveedor = idProveedor
        Me.idEmpleado = idEmpleado
        Me.idUsuario = idUsuario
    End Sub
End Class
