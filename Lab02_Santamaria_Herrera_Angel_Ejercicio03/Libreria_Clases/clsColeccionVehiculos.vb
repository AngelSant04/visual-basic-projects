Public Class clsColeccionVehiculos
    Private _total As Integer
    Private _datos() As clsVehiculo

    Public Sub agregar(obj As clsVehiculo)
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

    Public Function presentarXMarca(marca As String) As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            If _datos(i).getMarca = marca Then
                contenido = contenido & _datos(i).mostrar & vbCrLf
            End If
        Next
        Return contenido
    End Function

    Public Function buscarVehiculo(placa As String) As Integer
        For i = 0 To _total - 1
            If _datos(i).getPlaca = placa Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function buscarVehiculoXMarca(marca As String) As Integer
        For i = 0 To _total - 1
            If _datos(i).getMarca = marca Then
                Return i
            End If
        Next
        Return -1
    End Function
End Class
