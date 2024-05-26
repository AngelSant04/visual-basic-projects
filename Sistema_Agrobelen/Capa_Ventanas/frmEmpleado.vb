Imports Capa_Datos
Imports Capa_Entidades
Public Class frmEmpleado
    Private idEmpleado As String
    Protected Sub cargarDatos()
        Dim objADO As New clsEmpleadoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoTOTAL
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecial(texto As String)
        Dim objADO As New clsEmpleadoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletra(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecial_Nombre(texto As String)
        Dim objADO As New clsEmpleadoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombre(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New fmrMantEmpleado
        ventana.Show()
    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objAdo As New clsEmpleadoADO
        empleadoGlobal = objAdo.buscarEmpleado(idEmpleado)
        Dim ventana As New fmrMantEmpleado()
        ventana.Show()
    End Sub

    Private Sub txtEmpleado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmpleado.KeyUp
        Dim caracter As Char
        caracter = Mid(txtEmpleado.Text, 1, 1)
        If caracter = "0" Then
            cargarDatosEspecial(txtEmpleado.Text)
        Else
            cargarDatosEspecial_Nombre(txtEmpleado.Text)
        End If
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        idEmpleado = dgvDatos.SelectedRows().Item(0).Cells(0).Value
    End Sub

    Private Sub dgvDatos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvDatos.MouseDoubleClick
        Dim objAdo As New clsEmpleadoADO
        empleadoGlobal = objAdo.buscarEmpleado(idEmpleado)
        Dim ventana As New fmrMantEmpleado()
        ventana.Show()
    End Sub
End Class