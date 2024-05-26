Public Class Form1
    Private Sub RegistraEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistraEmpleadoToolStripMenuItem.Click
        Dim ventana As New frmRegistrarEmpleado

        ventana.ShowDialog()
    End Sub

    Private Sub RegistraVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistraVentaToolStripMenuItem.Click
        Dim ventana As New frmRegistraVenta

        ventana.ShowDialog()
    End Sub

    Private Sub ListadoDeVentasParaEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeVentasParaEmpleadoToolStripMenuItem.Click
        Dim ventana As New frmListadoVentasEmpleado

        ventana.ShowDialog()
    End Sub

    Private Sub TotalesAcumuladosDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesAcumuladosDeEmpleadosToolStripMenuItem.Click
        Dim ventana As New frmTotalesAcumulados

        ventana.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
