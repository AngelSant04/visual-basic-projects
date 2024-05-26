Public Class clsVentaCelular
    Inherits clsVenta

    Private _descripcion As String
    Private _marca As String
    Private _cantidadMeses As Integer

    Sub New()

    End Sub

    Sub New(numero As Integer, tipo As String, monto As Double, descripcion As String, marca As String, cantidad As Integer)
        MyBase.New(numero, tipo, monto)
        _descripcion = descripcion
        _marca = marca
        _cantidadMeses = cantidad
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar() & " - " & _descripcion & " - " & _marca & " - " & _cantidadMeses
    End Function

End Class
