Public Class clsEmpleado
    Private _DNI As String
    Private _nombres As String
    Private _edad As Integer
    Private _direccion As String
    Private area As clsAreaAsignada

    Sub New()

    End Sub

    Sub New(DNI As String, nombres As String, edad As Integer, direccion As String, obj As clsAreaAsignada)
        _DNI = DNI
        _nombres = nombres
        _edad = edad
        _direccion = direccion
        area = New clsAreaAsignada(obj.getNombre, obj.getDescripcion)
    End Sub

    Public Function mostrar() As String
        Return _DNI & " - " & _nombres & " - " & _edad & " - " & _direccion & " - " & area.mostrar
    End Function

    Public Function areaAsignada() As String
        Return area.getNombre
    End Function

    Public Function getDNI() As String
        Return _DNI
    End Function

End Class
