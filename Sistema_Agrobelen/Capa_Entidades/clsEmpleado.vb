Public Class clsEmpleado
    Property idEmpleado As String
    Property nombres As String
    Property apPaterno As String
    Property apMaterno As String
    Property fechaIngreso As Date
    Property sueldo As Double
    Public Sub New(idEmpleado As String, nombres As String, apPaterno As String, apMaterno As String, fechaIngreso As Date, sueldo As Double)
        Me.idEmpleado = idEmpleado
        Me.nombres = nombres
        Me.apPaterno = apPaterno
        Me.apMaterno = apMaterno
        Me.fechaIngreso = fechaIngreso
        Me.sueldo = sueldo
    End Sub
End Class
