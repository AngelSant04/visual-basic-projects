Public Class Form1
    Private Sub REGISTRARUNAREAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARUNAREAToolStripMenuItem.Click
        Dim ventana As New frmRegistrarArea

        ventana.ShowDialog()
    End Sub

    Private Sub REGISTRARUNEMPLEADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARUNEMPLEADOToolStripMenuItem.Click
        Dim ventana As New frmRegistrarEmpleado

        ventana.ShowDialog()
    End Sub

    Private Sub LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem.Click
        Dim ventana As New frmDatosEmpleados

        ventana.ShowDialog()
    End Sub

    Private Sub MODIFICARAREADEEMPLEADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARAREADEEMPLEADOToolStripMenuItem.Click
        Dim ventana As New frmModificarArea

        ventana.ShowDialog()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
