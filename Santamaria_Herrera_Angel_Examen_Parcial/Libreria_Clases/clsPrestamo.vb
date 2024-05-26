Public MustInherit Class clsPrestamo
    Private _DniCliente As String
    Private _codigo As String
    Private _fecha As Date
    Protected _monto As Integer
    Private _anios As Integer
    Protected _interes As Integer
    Protected _MontoTotal As Double
    Protected _MontoXMes As Double

    Sub New()

    End Sub
    Sub New(dniCliente As String, codigo As String, fecha As Date, monto As Integer, anios As Integer, interes As Integer)
        _DniCliente = dniCliente
        _codigo = codigo
        _fecha = fecha
        _monto = monto
        _anios = anios
        _interes = interes
    End Sub

    Public Overridable Function mostrar() As String
        Return _DniCliente & " - " & _codigo & " - " & _fecha & " - " & _monto & " - " & _anios & " - " & _interes
    End Function
    Public MustOverride Sub calcularMonto()

End Class
