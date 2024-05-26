Public Class clsColeccionAlumnos
    Private _total As Integer
    Private _datos() As clsAlumno

    Public Sub agregar(obj As clsAlumno)
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

    Public Function buscarAlumno(dniAux As String) As Integer
        For i = 0 To _total - 1
            If _datos(i).GSDNI = dniAux Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function copiarAlumno(dniAux As String) As clsAlumno
        Dim alumnoAux As clsAlumno
        For i = 0 To _total - 1
            If _datos(i).GSDNI = dniAux Then
                Return _datos(i)
            End If
        Next
        Return alumnoAux
    End Function

End Class
