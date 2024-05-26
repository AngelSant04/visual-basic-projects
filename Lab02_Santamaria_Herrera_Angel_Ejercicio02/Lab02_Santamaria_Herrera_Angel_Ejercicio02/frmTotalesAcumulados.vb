Public Class frmTotalesAcumulados
    Private Sub frmTotalesAcumulados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMontos()
        cargarDatos()
    End Sub

    Public Sub cargarMontos()
        For i = 0 To coleccionEmpleados.getTotal - 1
            coleccionEmpleados.getEmpleado(i).hallarMonto()
        Next
    End Sub

    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionEmpleados.getTotal - 1
            lstDatos.Items.Add(coleccionEmpleados.getEmpleado(i).mostrarConMonto)
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class