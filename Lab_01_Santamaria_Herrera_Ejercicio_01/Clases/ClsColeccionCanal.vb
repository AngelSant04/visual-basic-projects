Public Class ClsColeccionCanal
    Private _total As Integer
    Private _datos() As clsCanal


    Public Sub agregar(obj As clsCanal)
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

    Public Function Tipo(TipoAux As Integer) As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            contenido = contenido & _datos(i).mostrarProgramasXTipo(TipoAux)
        Next
        Return contenido
    End Function


    'Public Function getTotal() As Integer
    '    Return _total
    'End Function

    Public Function buscarCanal(nombAux As String) As Integer
        For i = 0 To _total - 1
            If nombAux = _datos(i).GSNombre Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function buscarPrograma(pos As Integer, nombAux As String) As Integer
        Return _datos(pos).buscarProgramaEnCanal(nombAux)
    End Function

    Public Sub agregarProgramaEnCanal(programa As ClsPrograma, pos As Integer)
        _datos(pos).agregarPrograma(programa)
    End Sub

    Public Function vistaProgramas(pos As Integer) As String
        Return _datos(pos).mostrarProgramas
    End Function

    Public Function verPrograma(posCanal As Integer, pos As Integer) As String
        Return _datos(posCanal).mostrarPrograma(pos)
    End Function

    Public Sub cambiarHora(posCanal As Integer, posPrograma As Integer, horaAux As Integer)
        _datos(posCanal).cambiarHoraPrograma(posPrograma, horaAux)
    End Sub

End Class
