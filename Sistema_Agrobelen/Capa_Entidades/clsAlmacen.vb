Public Class clsAlmacen
    Property idAlmacen As Integer
    Property sucursal As String
    Property descripcion As String
    Public Sub New(idAlmacen As Integer, sucursal As String, descripcion As String)
        Me.idAlmacen = idAlmacen
        Me.sucursal = sucursal
        Me.descripcion = descripcion
    End Sub
End Class
