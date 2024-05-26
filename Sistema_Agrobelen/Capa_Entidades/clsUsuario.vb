Public Class clsUsuario
    Property idEmpleado As String
    Property clave As String
    Property idCategoriaUsuario As Integer
    Property estado As String
    Property idUsuario As String
    Public Sub New(idEmpleado As String, clave As String, idCategoriaUsuario As Integer, estado As String, idUsuario As String)
        Me.idEmpleado = idEmpleado
        Me.clave = clave
        Me.idCategoriaUsuario = idCategoriaUsuario
        Me.estado = estado
        Me.idUsuario = idUsuario
    End Sub
End Class
