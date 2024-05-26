Public Class clsServicioCable
    Inherits clsVentaServicio

    Private _cantidadCanales As Integer
    Private _cantidadPuntos As Integer

    Sub New()

    End Sub

    Sub New(numero As Integer, tipoVenta As String, monto As Double, tipoServicio As String, cantCanales As Integer, cantPuntos As Integer)
        MyBase.New(numero, tipoVenta, monto, tipoServicio)
        _cantidadCanales = cantCanales
        _cantidadPuntos = cantPuntos
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar() & " - " & _cantidadCanales & " - " & _cantidadPuntos
    End Function

End Class
