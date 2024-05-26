Public Class clsEmpleado

    Property DNI As String
    Property nombres As String
    Property areas As String
    Public Sub New(dNI As String, nombres As String, areas As String)
        Me.DNI = dNI
        Me.nombres = nombres
        Me.areas = areas
    End Sub
End Class
