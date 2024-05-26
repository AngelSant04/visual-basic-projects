Public Class clsVentaServicio
    Inherits clsVenta

    Private _tipoServicio As String

    'Si es 0 es internet si es 1 cable

    Sub New()

    End Sub

    Sub New(numero As Integer, tipoVenta As String, monto As Double, tipoServicio As String)
        MyBase.New(numero, tipoVenta, monto)
        _tipoServicio = tipoServicio
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar & " - " & _tipoServicio
    End Function
End Class
