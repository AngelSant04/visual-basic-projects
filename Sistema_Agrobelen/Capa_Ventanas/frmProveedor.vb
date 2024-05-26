Imports Capa_Datos
Imports Capa_Entidades
Public Class frmProveedor
    Private idProveedor As String
    Protected Sub cargarDatosEspecial(texto As String)
        Dim objADO As New clsProveedorADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletra(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecial_Nombre(texto As String)
        Dim objADO As New clsProveedorADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombre(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatos()
        Dim objADO As New clsProveedorADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New frmMantProveedor
        ventana.Show()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objAdo As New clsProveedorADO
        proveedorGlobal = objAdo.buscarProveedor(idProveedor)
        Dim ventana As New frmMantProveedor()
        ventana.Show()

    End Sub
    Private Sub txtProveedor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyUp
        Dim valor As String
        Dim band As Integer = 0
        valor = txtProveedor.Text
        If IsNumeric(valor) Then
            band = 1
        End If
        If band = 1 Then
            cargarDatosEspecial(txtProveedor.Text)
        Else
            cargarDatosEspecial_Nombre(txtProveedor.Text)
        End If
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        idProveedor = dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString
    End Sub
End Class