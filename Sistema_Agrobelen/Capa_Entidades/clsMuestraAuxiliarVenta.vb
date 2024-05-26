Public Class clsMuestraAuxiliarVenta
    Property ID As Integer
    Property NOMBRE As String
    Property CANTIDAD As Integer
    Property PRECIO As Double
    Property IMPORTE As Double
    Public Sub New(idProducto As Integer, nombre As String, cantidad As Integer, preciO As Double, importe As Double)
        Me.ID = idProducto
        Me.NOMBRE = nombre
        Me.CANTIDAD = cantidad
        Me.PRECIO = preciO
        Me.importe = importe
    End Sub
End Class
