Public Class frmListadoVentasEmpleado
    Dim DniAux As String
    Private Sub cmbDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDNI.SelectedIndexChanged
        lstDatos.Items.Clear()
        Dim datos() As String = Split(cmbDNI.SelectedItem.ToString, "-")
        DniAux = datos(0).Trim
        For i = 0 To coleccionEmpleados.getTotal - 1
            If coleccionEmpleados.getEmpleado(i).getDNI = DniAux Then
                For j = 0 To coleccionEmpleados.getTotalVentas(i) - 1
                    lstDatos.Items.Add(coleccionEmpleados.getEmpleado(i).mostrarEspecial(j))
                Next
            End If
        Next
    End Sub

    Private Sub frmListadoVentasEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDNI.SelectedIndex = 0
        For i = 0 To coleccionEmpleados.getTotal - 1
            cmbDNI.Items.Add(coleccionEmpleados.getEmpleado(i).getDNIyNombre.ToString)
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class