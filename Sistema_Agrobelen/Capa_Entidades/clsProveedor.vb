Public Class clsProveedor
    Property idProveedor As String
    Property nombre As String
    Property tipoDocumento As String
    Property direccion As String
    Property correo As String
    Property telefono As String
    Property estado As String
    Public Sub New(idProveedor As String, nombre As String, tipoDocumento As String, direccion As String, correo As String, telefono As String, estado As String)
        Me.idProveedor = idProveedor
        Me.nombre = nombre
        Me.tipoDocumento = tipoDocumento
        Me.direccion = direccion
        Me.correo = correo
        Me.telefono = telefono
        Me.estado = estado
    End Sub
End Class
