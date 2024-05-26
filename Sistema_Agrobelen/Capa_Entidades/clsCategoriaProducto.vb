Public Class clsCategoriaProducto

    Property idCategoria As Integer
    Property descripcion As String

    Public Sub New(idCategoria As Integer, descripcion As String)
        Me.idCategoria = idCategoria
        Me.descripcion = descripcion
    End Sub
End Class
