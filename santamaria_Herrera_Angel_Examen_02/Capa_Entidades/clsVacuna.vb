Public Class clsVacuna
    Property idVacuna As Integer
    Property empresa As String
    Property cantidad As Integer
    Property fecha As Date
    Public Sub New(idVacuna As Integer, empresa As String, cantidad As Integer, fecha As Date)
        Me.idVacuna = idVacuna
        Me.empresa = empresa
        Me.cantidad = cantidad
        Me.fecha = fecha
    End Sub
End Class
