Public Class frmPrincipal
    Private Sub RegistrarTareaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarTareaToolStripMenuItem.Click
        Dim ventana As New frmRegistraTarea
        ventana.ShowDialog()
    End Sub

    Private Sub ProfesionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesionesToolStripMenuItem.Click
        Dim ventana As New frmMantenimientoProfesion
        ventana.ShowDialog()
    End Sub

    Private Sub AreasDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreasDeTrabajoToolStripMenuItem.Click
        Dim ventana As New frmMantenimientoAreaTrabajo
        ventana.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim ventana As New frmMantenimientoEmpleados
        ventana.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ListadoDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpleadosToolStripMenuItem.Click
        Dim ventana As New frmEjemploReporte
        ventana.ShowDialog()
    End Sub
End Class