Public Class clsPrestamoPersonalEmprendimientos
    Inherits clsPrestamoPersonal

    Private _tipo As String

    Sub New()

    End Sub

    Sub New(dniCliente As String, codigo As String, fecha As Date, monto As Integer, anios As Integer, interes As Integer, finalidad As String, tipo As String)
        MyBase.New(dniCliente, codigo, fecha, monto, anios, interes, finalidad)
        _tipo = tipo
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar() & " - " & _tipo
    End Function
End Class
