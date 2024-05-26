Public Class clsAreas
    Private _Jefe As String
    Private _nombre As String
    Private _CantidadEmpleados As Integer

    Sub New()

    End Sub

    Sub New(jefe As String, nombre As String, cantidad As Integer)
        _Jefe = jefe
        _nombre = nombre
        _CantidadEmpleados = cantidad
    End Sub

    Public Function getJefe() As String
        Return _Jefe
    End Function

    Public Function getNombre() As String
        Return _nombre
    End Function

    Public Function getCantidad() As String
        Return _CantidadEmpleados
    End Function

    Public Function mostrar() As String
        Return _nombre & " - " & _Jefe & " - " & _CantidadEmpleados
    End Function

    Public Sub reducirCantidad()
        _CantidadEmpleados = _CantidadEmpleados - 1
    End Sub

    Public Sub AumentarCantidad()
        _CantidadEmpleados = _CantidadEmpleados + 1
    End Sub

End Class
