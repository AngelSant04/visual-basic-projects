Public Class clsAsignacionTarea
    Property idAsignacion As Integer
    Property fechaAcceso As Date
    Property horaEntrada As TimeSpan
    Property horaSalida As TimeSpan
    Property tareaAsignada As String
    Property DNI As String
    Property idArea As Integer
    Property estado As Integer
    Public Sub New(idAsignacion As Integer, fechaAcceso As Date, horaEntrada As TimeSpan, horaSalida As TimeSpan, tareaAsignada As String, dNI As String, idArea As Integer, estado As Integer)
        Me.idAsignacion = idAsignacion
        Me.fechaAcceso = fechaAcceso
        Me.horaEntrada = horaEntrada
        Me.horaSalida = horaSalida
        Me.tareaAsignada = tareaAsignada
        Me.DNI = dNI
        Me.idArea = idArea
        Me.estado = estado
    End Sub
End Class
