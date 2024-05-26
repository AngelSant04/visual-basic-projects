Imports Capa_Entidades
Imports Capa_Datos
Public Class frmProducto
    Private _producto As Integer
    Private _almacen As Integer
    Protected Sub cargarDatos()
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New frmMantProducto
        ventana.Show()
    End Sub



    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        _producto = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value)
        '_almacen = CInt(dgvDatos.SelectedRows().Item(0).Cells(1).Value)
    End Sub

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objAdo As New clsProductoADO
        Dim objAdoInventario As New clsInventarioADO
        productoGlobal = objAdo.buscarProducto(_producto)
        inventarioGlobal = objAdoInventario.buscarInventario(_producto, _almacen)
        Dim ventana As New frmMantProducto
        ventana.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Protected Sub cargarDatosEspecial(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletra(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecial_Nombre(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombre(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtEmpleado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyUp
        Dim valor As String
        Dim band As Integer = 0
        valor = txtProducto.Text
        If IsNumeric(valor) Then
            band = 1
        End If
        If band = 1 Then
            cargarDatosEspecial(txtProducto.Text)
        Else
            cargarDatosEspecial_Nombre(txtProducto.Text)
        End If

    End Sub

End Class