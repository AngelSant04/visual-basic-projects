Public Class frmDatosEmpleados

    Private Sub frmDatosEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbArea.SelectedIndex = 0
        For i = 0 To coleccionAreas.getTotal - 1
            cmbArea.Items.Add(coleccionAreas.getArea(i).getNombre.ToString)
        Next
    End Sub

    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArea.SelectedIndexChanged
        lstDatos.Items.Clear()
        For i = 0 To coleccionEmpleado.getTotal - 1
            If coleccionEmpleado.getEmpleado(i).areaAsignada = cmbArea.SelectedItem.ToString Then
                lstDatos.Items.Add(coleccionEmpleado.getEmpleado(i).mostrar)
            End If
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class