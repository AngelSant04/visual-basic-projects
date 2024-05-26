Public Class clsComunidad
    Private _nombreComunidad As String
    Private _distrito As String
    Private _representante As String
    Private _tipoComunidad As Integer

    Public Sub New(nombre As String, distrito As String, representante As String, tComunidad As Integer)
        _nombreComunidad = nombre
        _distrito = distrito
        _representante = representante
        _tipoComunidad = tComunidad
    End Sub

    Public Function mostrar() As String
        Return _nombreComunidad & " - " & _distrito & " - " & _representante & " - " & _tipoComunidad
    End Function

    Public Property GSNombre As String
        Get
            Return _nombreComunidad
        End Get
        Set(value As String)
            _nombreComunidad = value
        End Set
    End Property

    Public Property GSRepresentante As String
        Get
            Return _representante
        End Get
        Set(value As String)
            _representante = value
        End Set
    End Property

End Class
