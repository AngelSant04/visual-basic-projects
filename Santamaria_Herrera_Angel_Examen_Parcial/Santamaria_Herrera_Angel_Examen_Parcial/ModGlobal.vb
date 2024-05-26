Imports Libreria_Clases
Module ModGlobal
    Public coleccionClientes As New ArrayList
    Public coleccionPrestamos As New ArrayList

    Public Function buscarCliente(DNI As String) As Integer
        For i = 0 To coleccionClientes.Count - 1
            If coleccionClientes.Item(i).getDNI = DNI Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function buscarClienteXTipo(DNI As String) As Integer
        For i = 0 To coleccionClientes.Count - 1
            If coleccionClientes.Item(i).getDNI = DNI Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module
