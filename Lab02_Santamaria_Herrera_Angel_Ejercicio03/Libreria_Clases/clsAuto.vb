Public Class clsAuto
    Inherits clsVehiculo

    Private _tipo As Integer    '1- Automatico 2- Mecanico
    Sub New()

    End Sub
    Sub New(placa As String, marca As String, modelo As String, tipo As Integer)
        MyBase.New(placa, marca, modelo)
        _tipo = tipo
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar & " - " & _tipo
    End Function

End Class
