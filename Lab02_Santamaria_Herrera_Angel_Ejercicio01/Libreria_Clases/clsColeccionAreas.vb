Public Class clsColeccionAreas
    Private _datos() As clsAreas     'Dinamico
    Private _total As Integer


    'Lista dinamica que no tiene un numero definido de Cuentas, por ende no necesita
    'Constructor
    Public Sub agregar(obj As clsAreas)
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

    Public Function getTotal() As Integer
        Return _total
    End Function

    Public Function getArea(pos As Integer) As clsAreas
        Return _datos(pos)
    End Function

End Class
