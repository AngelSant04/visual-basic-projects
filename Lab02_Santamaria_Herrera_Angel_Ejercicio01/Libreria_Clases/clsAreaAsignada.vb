Public Class clsAreaAsignada
    Private _nombre As String
    Private _descripcion As String

    Sub New()

    End Sub

    Sub New(nombre As String, descripcion As String)
        _nombre = nombre
        _descripcion = descripcion
    End Sub

    Public Function mostrar() As String
        Return _nombre & " - " & _descripcion
    End Function

    Public Function getNombre() As String
        Return _nombre
    End Function

    Public Function getDescripcion() As String
        Return _descripcion
    End Function
End Class
