Public Class clsDetalleCompra
    Property idDetalleCompra As Integer
    Property Cantidad As Integer
    Property subTotal As Double
    Property idCompra As Integer
    Property idProducto As Integer
    Public Sub New(idDetalleCompra As Integer, cantidad As Integer, subTotal As Double, idCompra As Integer, idProducto As Integer)
        Me.idDetalleCompra = idDetalleCompra
        Me.Cantidad = cantidad
        Me.subTotal = subTotal
        Me.idCompra = idCompra
        Me.idProducto = idProducto
    End Sub
End Class
