Public Class clsVehiculo
    Private _placa As String
    Private _marca As String
    Private _modelo As String

    Sub New()

    End Sub
    Sub New(placa As String, marca As String, modelo As String)
        _placa = placa
        _marca = marca
        _modelo = modelo
    End Sub

    Public Overridable Function mostrar() As String
        Return _placa & " - " & _marca & " - " & _modelo
    End Function

    Public Function getPlaca() As String
        Return _placa
    End Function

    Public Function getMarca() As String
        Return _marca
    End Function
End Class
