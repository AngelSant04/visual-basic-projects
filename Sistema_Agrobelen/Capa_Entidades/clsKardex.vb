Public Class clsKardex
    Public Sub New(idKardex As Integer, fecha As Date, tipoMovimiento As String, descripcion As String, sucursalRef As String, stockRealRef As Integer, idProducto As Integer, idAlmacen As Integer, docRef As String, responsable As String, destino As String, precioRef As Double)
        Me.idKardex = idKardex
        Me.fecha = fecha
        Me.tipoMovimiento = tipoMovimiento
        Me.descripcion = descripcion
        Me.sucursalRef = sucursalRef
        Me.stockRealRef = stockRealRef
        Me.idProducto = idProducto
        Me.idAlmacen = idAlmacen
        Me.docRef = docRef
        Me.responsable = responsable
        Me.destino = destino
        Me.precioRef = precioRef
    End Sub

    Property idKardex As Integer
    Property fecha As Date
    Property tipoMovimiento As String
    Property descripcion As String
    Property sucursalRef As String
    Property stockRealRef As Integer
    Property idProducto As Integer
    Property idAlmacen As Integer
    Property docRef As String
    Property responsable As String
    Property destino As String
    Property precioRef As Double

End Class
