Public Class clsCanal
    Private _nombre As String
    Private _calidad As Integer
    Private _datos As ClsColeccionPrograma

    Public Sub New(nombre As String, calidad As Integer)
        _nombre = nombre
        _calidad = calidad
        _datos = New ClsColeccionPrograma()
    End Sub

    Public Property GSNombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property GSCalidad As Integer
        Get
            Return _calidad
        End Get
        Set(value As Integer)
            _calidad = value
        End Set
    End Property

    Public Function mostrar() As String
        Return _nombre & " - " & _calidad
    End Function

    Public Sub agregarPrograma(programa As ClsPrograma)
        _datos.agregar(programa)
    End Sub

    Public Function mostrarProgramas() As String
        Return _datos.presentar
    End Function

    Public Function mostrarPrograma(pos As Integer) As String
        Return _datos.presentarPrograma(pos)
    End Function

    Public Function mostrarProgramasXTipo(tipo As Integer) As String
        Return _datos.presentarXTipo(tipo)
    End Function

    Public Function buscarProgramaEnCanal(nombAux As String) As Integer
        For i = 0 To _datos.getTotal - 1
            If nombAux = _datos.buscarNombre(i) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub cambiarHoraPrograma(posPrograma As Integer, horaAux As Integer)
        _datos.cambiarHoraPrograma(posPrograma, horaAux)
    End Sub

End Class
