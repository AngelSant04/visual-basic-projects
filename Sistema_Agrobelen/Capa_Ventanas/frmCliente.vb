Imports Capa_Datos
Imports Capa_Entidades
Public Class frmCliente
    Private idCliente As String
    Protected Sub cargarDatosxID(texto As String)
        Dim objADO As New clsClienteADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletra(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosXNombre(texto As String)
        Dim objADO As New clsClienteADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombre(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatos()
        Dim objADO As New clsClienteADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New frmMantCliente
        ventana.Show()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objAdo As New clsClienteADO
        clienteGlobal = objAdo.buscarCliente(idCliente)
        Dim ventana As New frmMantCliente()
        ventana.Show()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        idCliente = dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString
    End Sub

    Private Sub txtCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyUp
        Dim valor As String
        Dim band As Integer = 0
        valor = txtCliente.Text
        If IsNumeric(valor) Then
            band = 1
        End If
        If band = 1 Then
            cargarDatosxID(txtCliente.Text)
        Else
            cargarDatosXNombre(txtCliente.Text)
        End If
    End Sub
End Class