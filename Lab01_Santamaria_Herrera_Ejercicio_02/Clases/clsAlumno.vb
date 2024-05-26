Public Class clsAlumno
    Private _DNI As String
    Private _nombre As String
    Private _correo As String

    Public Sub New(dni As String, nombre As String, correo As String)
        _DNI = dni
        _nombre = nombre
        _correo = correo
    End Sub

    Public Property GSDNI As String
        Get
            Return _DNI
        End Get
        Set(value As String)
            _DNI = value
        End Set
    End Property
    Public Property GSNombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property GSCorreo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Function mostrar() As String
        Return _DNI & " - " & _nombre & " - " & _correo
    End Function

End Class
