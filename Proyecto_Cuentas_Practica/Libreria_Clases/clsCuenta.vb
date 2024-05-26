Public Class clsCuenta

    'Variables
    Private _numCuenta As String
    Private _DNI As String
    Private _saldo As Double
    Private _propietario As String
    Private _TipoCuenta As Integer

    'Constructores
    Sub New(num As String, dni As String, saldo As Double,
            propietario As String, tipo As Integer)
        _numCuenta = num
        _DNI = dni
        _saldo = saldo
        _propietario = propietario
        _TipoCuenta = tipo
    End Sub

    'Funciones, Metodos
    'Para todas su get y set
    Public Property GSnumCuenta As String
        Get 'Devolver
            Return _numCuenta
        End Get
        Set(value As String)    'Cambiar
            _numCuenta = value
        End Set
    End Property
    Public Property GSDNI As String
        Get 'Devolver
            Return _DNI
        End Get
        Set(value As String)    'Cambiar
            _DNI = value
        End Set
    End Property
    Public Property GSSaldo As String
        Get 'Devolver
            Return _saldo
        End Get
        Set(value As String)    'Cambiar
            _saldo = value
        End Set
    End Property
    Public Property GSPropietario As String
        Get 'Devolver
            Return _propietario
        End Get
        Set(value As String)    'Cambiar
            _propietario = value
        End Set
    End Property
    Public Property GStipoCuenta As String
        Get 'Devolver
            Return _TipoCuenta
        End Get
        Set(value As String)    'Cambiar
            _TipoCuenta = value
        End Set
    End Property

    Public Function mostrar() As String
        Return _numCuenta & " - " & _DNI & " - " & _saldo & " - " & _propietario
    End Function

End Class
