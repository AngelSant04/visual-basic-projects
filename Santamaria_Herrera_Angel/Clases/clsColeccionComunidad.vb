Public Class clsColeccionComunidad
    Private _total As Integer
    Private _datos() As clsComunidad

    Public Sub agregar(obj As clsComunidad)
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

    Public Function buscarComunidad(nombre As String) As Integer
        For i = 0 To _total - 1
            If _datos(i).GSNombre = nombre Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function regresarNombre(pos As Integer) As String
        Return _datos(pos).GSRepresentante
    End Function
End Class
