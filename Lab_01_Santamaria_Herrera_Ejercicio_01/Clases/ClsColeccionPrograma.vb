Public Class ClsColeccionPrograma
    Private _total As Integer
    Private _datos() As ClsPrograma

    Public Sub agregar(obj As ClsPrograma)
        ReDim Preserve _datos(_total)
        _datos(_total) = obj
        _total = _total + 1
    End Sub

    Public Function presentar() As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            contenido = contenido & _datos(i).mostrar & vbCrLf
        Next
        Return contenido
    End Function

    Public Function presentarXTipo(tipo As Integer) As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            If _datos(i).GSTransmision = tipo Then
                contenido = contenido & _datos(i).mostrar & vbCrLf
            End If
        Next
        Return contenido
    End Function

    Public Function getTotal() As Integer
        Return _total
    End Function

    Public Function buscarNombre(pos As Integer) As String
        Return _datos(pos).GSPrograma
    End Function

    Public Function presentarPrograma(pos As Integer) As String
        Return _datos(pos).mostrar
    End Function

    Public Sub cambiarHoraPrograma(posPrograma As Integer, horaAux As Integer)
        _datos(posPrograma).cambiarHora(horaAux)
    End Sub

End Class
