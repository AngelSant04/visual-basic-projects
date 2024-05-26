Public Class clsDetalleVenta
    Property idDetalleVenta As Integer
    Property Cantidad As Integer
    Property Subtotal As Double
    Property idVenta As Integer
    Property idProducto As Integer
    Public Sub New(idDetalleVenta As Integer, cantidad As Integer, subtotal As Double, idVenta As Integer, idProducto As Integer)
        Me.idDetalleVenta = idDetalleVenta
        Me.Cantidad = cantidad
        Me.Subtotal = subtotal
        Me.idVenta = idVenta
        Me.idProducto = idProducto
    End Sub
End Class
