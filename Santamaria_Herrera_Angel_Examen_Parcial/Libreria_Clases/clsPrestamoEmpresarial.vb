Public Class clsPrestamoEmpresarial
    Inherits clsPrestamo

    Private _finalidad As String
    Private _documento As String
    Private _capital As Double

    Sub New()

    End Sub
    Sub New(dniCliente As String, codigo As String, fecha As Date, monto As Integer, anios As Integer, interes As Integer, finalidad As String, documento As String, capital As Double)
        MyBase.New(dniCliente, codigo, fecha, monto, anios, interes)
        _finalidad = finalidad
        _documento = documento
        _capital = capital
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar() & " - " & _finalidad & " - " & _documento & " - " & _capital
    End Function

    Public Overrides Sub calcularMonto()
        _MontoTotal = (_interes * _monto) / 100 + _monto
    End Sub
End Class
