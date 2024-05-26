Public Class clsServicioInternet
    Inherits clsVentaServicio

    Private _gigas As Integer

    Sub New()

    End Sub

    Sub New(numero As Integer, tipoVenta As String, monto As Double, tipoServicio As String, gigas As Integer)
        MyBase.New(numero, tipoVenta, monto, tipoServicio)
        _gigas = gigas
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar() & " - " & _gigas
    End Function
End Class
