Public Class frmModificarPrestamo
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub frmModificarPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatos()
    End Sub

    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionPrestamos.Count - 1
            lstDatos.Items.Add(coleccionPrestamos.Item(i).mostrar)
        Next
    End Sub

    Private Sub lstDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDatos.SelectedIndexChanged
        Dim datos() As String = Split(lstDatos.SelectedItem.ToString, "-")
        txtMonto.Text = datos(3).Trim
        txtDevolucion.Text = datos(4).Trim
        'cmbMotivoPP.SelectedIndex = datos()
    End Sub
End Class