Public Class clsPrestamoPersonal
    Inherits clsPrestamo

    Private _finalidad As String

    Sub New()

    End Sub
    Sub New(dniCliente As String, codigo As String, fecha As Date, monto As Integer, anios As Integer, interes As Integer, finalidad As String)
        MyBase.New(dniCliente, codigo, fecha, monto, anios, interes)
        _finalidad = finalidad
    End Sub
    Public Overrides Function mostrar() As String
        Return MyBase.mostrar() & " - " & _finalidad
    End Function
    Public Overrides Sub calcularMonto()
        _MontoTotal = (_interes * _monto) / 100 + _monto
    End Sub
End Class
