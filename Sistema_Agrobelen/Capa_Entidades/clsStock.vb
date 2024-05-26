Public Class clsStock
    Property idAlmacen As Integer
    Property idStock As Integer
    Property stockMinimo As Integer
    Property stockMaximo As Integer
    Property idProducto As Integer
    Public Sub New(idAlmacen As Integer, idStock As Integer, stockMinimo As Integer, stockMaximo As Integer, idProducto As Integer)
        Me.idAlmacen = idAlmacen
        Me.idStock = idStock
        Me.stockMinimo = stockMinimo
        Me.stockMaximo = stockMaximo
        Me.idProducto = idProducto
    End Sub
End Class
