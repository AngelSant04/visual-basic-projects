Public Class clsDistrito
    Property idDistrito As Integer
    Property descripcion As String
    Public Sub New(idDistrito As Integer, descripcion As String)
        Me.idDistrito = idDistrito
        Me.descripcion = descripcion
    End Sub
End Class
