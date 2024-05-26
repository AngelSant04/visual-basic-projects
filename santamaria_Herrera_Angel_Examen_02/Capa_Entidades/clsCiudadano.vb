Public Class clsCiudadano
    Public Sub New(dNI As String, nombres As String, apPaterno As String, apMaterno As String, fecha As Date, idDistrito As Integer)
        Me.DNI = dNI
        Me.nombres = nombres
        Me.apPaterno = apPaterno
        Me.apMaterno = apMaterno
        Me.fecha = fecha
        Me.idDistrito = idDistrito
    End Sub

    Property DNI As String
    Property nombres As String
    Property apPaterno As String
    Property apMaterno As String
    Property fecha As Date
    Property idDistrito As Integer
End Class
