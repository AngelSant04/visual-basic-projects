Public Class clsCombi
    Inherits clsVehiculo

    Private _cantidadAsientos As Integer
    Sub New()

    End Sub
    Sub New(placa As String, marca As String, modelo As String, cantidad As Integer)
        MyBase.New(placa, marca, modelo)
        _cantidadAsientos = cantidad
    End Sub

    Public Overrides Function mostrar() As String
        Return MyBase.mostrar & " - " & _cantidadAsientos
    End Function

End Class
