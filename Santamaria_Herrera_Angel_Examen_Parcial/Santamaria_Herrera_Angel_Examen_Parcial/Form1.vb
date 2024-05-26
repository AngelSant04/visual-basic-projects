Public Class Form1
    Private Sub RegistrarUnClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUnClienteToolStripMenuItem.Click
        Dim ventana As New frmRegistrarCliente

        ventana.ShowDialog()
    End Sub

    Private Sub RegistrarUnPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUnPrestamoToolStripMenuItem.Click
        Dim ventana As New frmRegistrarPrestamo

        ventana.ShowDialog()
    End Sub

    Private Sub CalculoDeCuotasDePrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoDeCuotasDePrestamosToolStripMenuItem.Click
        Dim ventana As New frmRegistrarPrestamo

        ventana.ShowDialog()
    End Sub

    Private Sub ModificarPrestamoDeUnClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPrestamoDeUnClienteToolStripMenuItem.Click
        Dim ventana As New frmModificarPrestamo

        ventana.ShowDialog()
    End Sub
End Class
