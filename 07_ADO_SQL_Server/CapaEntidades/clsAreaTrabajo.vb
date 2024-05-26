Public Class clsAreaTrabajo
    Property idArea As Integer
    Property descripcion As String
    Property nombJefe As String
    Public Sub New(idArea As Integer, descripcion As String, nombJefe As String)
        Me.idArea = idArea
        Me.descripcion = descripcion
        Me.nombJefe = nombJefe
    End Sub

End Class
