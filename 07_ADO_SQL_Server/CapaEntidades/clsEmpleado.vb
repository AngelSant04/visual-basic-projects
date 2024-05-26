Public Class clsEmpleado
    Property DNI As String
    'Es como si le estuviera desarrollando el GET y SET
    Property nombres As String
    Property apPaterno As String
    Property apMaterno As String
    Property fechaNac As Date
    Property estado As Boolean
    Property usuario As String
    Property clave As String
    Property idProfesion As Integer
    Property tipo As Integer

    Public Sub New(dNI As String, nombres As String, apPaterno As String, apMaterno As String, fechaNac As Date, estado As Boolean, usuario As String, clave As String, idProfesion As Integer, tipo As Integer)
        Me.DNI = dNI
        Me.nombres = nombres
        Me.apPaterno = apPaterno
        Me.apMaterno = apMaterno
        Me.fechaNac = fechaNac
        Me.estado = estado
        Me.usuario = usuario
        Me.clave = clave
        Me.idProfesion = idProfesion
        Me.tipo = tipo
    End Sub

End Class
