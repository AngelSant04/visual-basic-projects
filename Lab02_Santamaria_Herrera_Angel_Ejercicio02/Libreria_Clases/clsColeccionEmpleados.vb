Public Class clsColeccionEmpleados
    Private _datos() As clsEmpleado     'Dinamico
    Private _total As Integer
    Public Sub agregar(obj As clsEmpleado)
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

    Public Sub modificarEmpleado(pos As Integer, obj As clsEmpleado)
        _datos(pos) = obj
    End Sub

    Public Function getTotal() As Integer
        Return _total
    End Function

    Public Function getEmpleado(pos As Integer) As clsEmpleado
        Return _datos(pos)
    End Function

    Public Function getTotalVentas(pos As Integer) As Integer
        Return _datos(pos).getTotalVentas
    End Function
End Class
