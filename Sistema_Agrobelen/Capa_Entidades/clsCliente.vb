Public Class clsCliente

    Property idCliente As String
    Property nombres As String
    Property apPaterno As String
    Property apMaterno As String
    Property telefono As String
    Property correo As String
    Property direccion As String
    Property tipoDocumento As String
    Public Sub New(idNombres As String, nombres As String, apPaterno As String, apMaterno As String, telefono As String, correo As String, direccion As String, tipoDocumento As String)
        Me.idCliente = idNombres
        Me.nombres = nombres
        Me.apPaterno = apPaterno
        Me.apMaterno = apMaterno
        Me.telefono = telefono
        Me.correo = correo
        Me.direccion = direccion
        Me.tipoDocumento = tipoDocumento
    End Sub


End Class
