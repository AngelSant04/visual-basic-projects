Public Class Form1
    Private Sub RegistrarVacunasDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVacunasDisponiblesToolStripMenuItem.Click
        Dim ventana As New frmAgregarVacuna
        ventana.Show()
    End Sub

    Private Sub RegistrarTarjetaDeVacunacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarTarjetaDeVacunacionToolStripMenuItem.Click
        Dim ventana As New frmRegistrarTarjeta
        ventana.Show()
    End Sub
End Class
