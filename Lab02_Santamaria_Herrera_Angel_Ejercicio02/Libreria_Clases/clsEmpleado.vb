Public Class clsEmpleado
    Private _DNI As String
    Private _nombres As String
    Private _distrito As String
    Private _telefono As String
    Private _montoTotal As Double = 0
    Private _ventas As clsColeccionVentas

    Public Function getDNI() As String
        Return _DNI
    End Function
    Public Function getDNIyNombre() As String
        Return _DNI & " - " & _nombres
    End Function

    Public Function getNombres() As String
        Return _nombres
    End Function

    Public Function getDisrtito() As String
        Return _distrito
    End Function

    Public Function getTelefono() As String
        Return _telefono
    End Function
    Sub New()
        _ventas = New clsColeccionVentas
    End Sub

    Sub New(DNI As String, nombres As String, distrito As String, telefono As String)
        _DNI = DNI
        _nombres = nombres
        _distrito = distrito
        _telefono = telefono
        _ventas = New clsColeccionVentas
    End Sub

    Public Function mostrar() As String
        Return _DNI & "- " & _nombres & "- " & _distrito & "- " & _telefono
    End Function

    Public Function mostrarConMonto() As String
        Return _DNI & "- " & _nombres & "- " & _montoTotal
    End Function

    Public Function mostrarEspecial(pos As Integer) As String
        Return _ventas.getVenta(pos).mostrar
    End Function

    Public Sub agregarVenta(obj As clsVenta)
        _ventas.agregar(obj)
    End Sub

    Public Function getTotalVentas() As Integer
        Return _ventas.getTotal
    End Function

    Public Sub hallarMonto()
        For i = 0 To _ventas.getTotal - 1
            _montoTotal = _montoTotal + _ventas.getVenta(i).getMonto()
        Next
    End Sub

    Public Function getMontoTotal() As Double
        Return _montoTotal
    End Function
End Class
