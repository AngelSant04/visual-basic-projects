Public Class clsTarjetaVacuna
    Property DNI As String
    Property numDosis As Integer
    Property fecha As Date
    Property idVacuna As Integer
    Public Sub New(dNI As String, numDosis As Integer, fecha As Date, idVacuna As Integer)
        Me.DNI = dNI
        Me.numDosis = numDosis
        Me.fecha = fecha
        Me.idVacuna = idVacuna
    End Sub
End Class
