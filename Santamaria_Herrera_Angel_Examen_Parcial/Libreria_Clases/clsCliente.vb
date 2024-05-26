Public Class clsCliente
    Private _DNI As String
    Private _nombres As String
    Private _correo As String
    Private _tipoPersona As String
    Sub New()

    End Sub
    Sub New(dni As String, nombres As String, correo As String, tipo As String)
        _DNI = dni
        _nombres = nombres
        _correo = correo
        _tipoPersona = tipo
    End Sub
    Public Function getDni() As String
        Return _DNI
    End Function
    Public Function getTipo() As String
        Return _tipoPersona
    End Function
    Public Function mosrtarDNIyNombre() As String
        Return _DNI & " - " & _nombres
    End Function

    Public Function mostrar() As String
        Return _DNI & " - " & _nombres & " - " & _correo & " - " & _tipoPersona
    End Function
End Class
