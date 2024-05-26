Public Class clsColeccionCursos
    Private _total As Integer
    Private _datos() As clsCurso

    Public Sub agregar(obj As clsCurso)
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

    Public Function presentarAlumnos(idAux As String) As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            If _datos(i).GSId = idAux Then
                contenido = contenido & _datos(i).presentar
            End If
        Next
        Return contenido
    End Function

    Public Function presentarCursosNoLlevados(dniAux As String) As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            If _datos(i).buscarAlumno(dniAux) = -1 Then
                contenido = contenido & _datos(i).mostrar & vbCrLf
            End If
        Next
        Return contenido
    End Function

    Public Function presentarCursosMatriculados(dniAux As String) As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            If _datos(i).buscarAlumno(dniAux) <> -1 Then
                contenido = contenido & _datos(i).mostrar & vbCrLf
            End If
        Next
        Return contenido
    End Function

    Public Sub matricularAlumno(idAux As String, alumno As clsAlumno)
        For i = 0 To _total - 1
            If _datos(i).GSId = idAux Then
                _datos(i).actualizarAlumno(alumno)
                _datos(i).actualizarCuota()
            End If
        Next
    End Sub

    Public Sub actualizarPago(idAux As String)
        For i = 0 To _total - 1
            If _datos(i).GSId = idAux Then
                _datos(i).actualizarCuota()
            End If
        Next
    End Sub

    Public Function mostrarPagos(idAux As String) As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            If _datos(i).GSId = idAux Then
                contenido = contenido & _datos(i).mostrarPagos
            End If
        Next
        Return contenido
    End Function

    Public Function buscarCurso(idAux As String) As Integer
        For i = 0 To _total - 1
            If _datos(i).GSId = idAux Then
                Return i
            End If
        Next
        Return -1
    End Function

End Class
