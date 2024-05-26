Public Class clsColeccionVentas
    Private _datos() As clsVenta    'Dinamico
    Private _total As Integer
    Public Sub agregar(obj As clsVenta)
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

    Public Sub modificarEmpleado(pos As Integer, obj As clsVenta)
        _datos(pos) = obj
    End Sub

    Public Function getTotal() As Integer
        Return _total
    End Function

    Public Function getVenta(pos As Integer) As clsVenta
        Return _datos(pos)
    End Function
End Class
