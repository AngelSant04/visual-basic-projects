Public Class clsColeccionProductos
    Private _total As Integer
    Private _datos() As clsProducto

    Public Sub agregar(obj As clsProducto)
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

    Public Function buscarProducto(codigo As String) As Integer
        For i = 0 To _total - 1
            If _datos(i).GSCodigo = codigo Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function regresarProducto(codigo As String) As clsProducto
        Dim producto As clsProducto
        For i = 0 To _total - 1
            If _datos(i).GSCodigo = codigo Then
                Return _datos(i)
            End If
        Next
        Return producto
    End Function

    Public Sub actualizarStock(codigo As String, cantidad As Integer)
        Dim stock As Integer
        For i = 0 To _total - 1
            If _datos(i).GSCodigo = codigo Then
                stock = _datos(i).getCantidad - cantidad
                _datos(i).setCantidad(stock)
            End If
        Next
    End Sub

End Class
