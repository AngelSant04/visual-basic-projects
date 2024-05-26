Imports Libreria_Clases
Module ModGlobal
    Public coleccionAreas As New clsColeccionAreas
    Public coleccionEmpleado As New clsColeccionEmpleados

    Public Function buscarEmpleado(DNI As String) As Integer
        For i = 0 To coleccionEmpleado.getTotal - 1
            If coleccionEmpleado.getEmpleado(i).getDNI = DNI Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function buscarArea(nombAux As String) As Integer
        For i = 0 To coleccionAreas.getTotal - 1
            If coleccionAreas.getArea(i).getNombre = nombAux Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module
