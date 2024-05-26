Imports Libreria_Clases
Module ModGlobal
    Public coleccionVentas As New clsColeccionVentas
    Public coleccionEmpleados As New clsColeccionEmpleados

    Public Function buscarEmpleado(DNI As String) As Integer
        For i = 0 To coleccionEmpleados.getTotal - 1
            If coleccionEmpleados.getEmpleado(i).getDNI = DNI Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module
