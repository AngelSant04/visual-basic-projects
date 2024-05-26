Public Class clsProducto
    Property idProducto As Integer
    Property nombre As String
    Property estado As Integer
    Property precio As Double
    Property costo As Double
    Property idCategoria As Integer
    Property idProveedor As String
    Public Sub New(idProducto As Integer, nombre As String, estado As Integer, precio As Double, costo As Double, idCategoria As Integer, idProveedor As String)
        Me.idProducto = idProducto
        Me.nombre = nombre
        Me.estado = estado
        Me.precio = precio
        Me.costo = costo
        Me.idCategoria = idCategoria
        Me.idProveedor = idProveedor
    End Sub
End Class
