Public Class ClsPrograma
    Private _tipoTransmision As Integer
    Private _nombrePrograma As String
    Private _nombreDirector As String
    Private _programacion As ClsProgramacion

    Public Sub New(transmision As Integer, programa As String, director As String, programacion As ClsProgramacion)
        _tipoTransmision = transmision
        _nombrePrograma = programa
        _nombreDirector = director
        _programacion = programacion
    End Sub

    Public Property GSTransmision As Integer
        Get
            Return _tipoTransmision
        End Get
        Set(value As Integer)
            _tipoTransmision = value
        End Set
    End Property

    Public Property GSPrograma As String
        Get
            Return _nombrePrograma
        End Get
        Set(value As String)
            _nombrePrograma = value
        End Set
    End Property

    Public Property GSDirector As String
        Get
            Return _nombreDirector
        End Get
        Set(value As String)
            _nombreDirector = value
        End Set
    End Property

    Public Function mostrar() As String
        Return _nombreDirector & " - " & _tipoTransmision & " - " & _nombrePrograma & _programacion.mostrar()
    End Function

    Public Sub cambiarHora(horaAux As Integer)
        _programacion.setHora(horaAux)
    End Sub

End Class
