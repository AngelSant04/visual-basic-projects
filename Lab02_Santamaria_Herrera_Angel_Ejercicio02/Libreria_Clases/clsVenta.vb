Public Class clsVenta
    Private _numeroVenta As Integer
    Private _tipoVenta As String
    Private _monto As Double

    'Si es 0 es Celular si es 1 es Servicio de Conetividad

    Sub New()

    End Sub

    Sub New(numero As Integer, tipo As String, monto As Double)
        _numeroVenta = numero
        _tipoVenta = tipo
        _monto = monto
    End Sub

    Public Overridable Function mostrar() As String
        Return _numeroVenta & " - " & _tipoVenta & " - " & _monto
    End Function

    Public Function getMonto() As Double
        Return _monto
    End Function

End Class
