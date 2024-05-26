Public Class clsInventario
    Property idProducto As Integer
    Property idAlmacen As Integer
    Property stockMinimo As Integer
    Property stockMaximo As Integer
    Property stockReal As Integer
    Public Sub New(idProducto As Integer, idAlmacen As Integer, stockMinimo As Integer, stockMaximo As Integer, stockReal As Integer)
        Me.idProducto = idProducto
        Me.idAlmacen = idAlmacen
        Me.stockMinimo = stockMinimo
        Me.stockMaximo = stockMaximo
        Me.stockReal = stockReal
    End Sub
End Class
