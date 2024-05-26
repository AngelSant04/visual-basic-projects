Public Class clsVenta
    Public Sub New(idVenta As Integer, fecha As Date, formaPago As String, total As Double, igv As Double, subTotal As Double, idCliente As String, idEmpleado As String, estado As Integer, diasCredito As Integer, fechaPago As Date)
        Me.idVenta = idVenta
        Me.fecha = fecha
        Me.formaPago = formaPago
        Me.total = total
        Me.igv = igv
        Me.subTotal = subTotal
        Me.idCliente = idCliente
        Me.idEmpleado = idEmpleado
        Me.estado = estado
        Me.diasCredito = diasCredito
        Me.fechaPago = fechaPago
    End Sub

    Property idVenta As Integer
    Property fecha As Date
    Property formaPago As String
    Property total As Double
    Property igv As Double
    Property subTotal As Double
    Property idCliente As String
    Property idEmpleado As String

    Property estado As Integer
    Property diasCredito As Integer
    Property fechaPago As Date



End Class
