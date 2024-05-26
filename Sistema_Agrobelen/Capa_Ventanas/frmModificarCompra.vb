Imports Capa_Datos
Imports Capa_Entidades
Public Class frmModificarCompra
    Protected Sub cargarDatos()
        Dim objADO As New clsCompraADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecial(texto As String)
        Dim objADO As New clsCompraADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletra(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecial_Nombre(texto As String)
        Dim objADO As New clsCompraADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombre(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub frmModificarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarDatos()
    End Sub

    Private Sub txtProveedor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyUp
        Dim valor As String
        Dim band As Integer = 0
        If txtProveedor.Text = "" Then
            dtpFechaInicio.Enabled = True
            dtpFechaFinal.Enabled = True
            cargarDatos()
        Else
            dtpFechaInicio.Enabled = False
            dtpFechaFinal.Enabled = False
            valor = txtProveedor.Text
            If IsNumeric(valor) Then
                band = 1
            End If
            If band = 1 Then
                cargarDatosEspecial(txtProveedor.Text)
            Else
                cargarDatosEspecial_Nombre(txtProveedor.Text)
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim objADO As New clsCompraADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXFechas(dtpFechaInicio.Value, dtpFechaFinal.Value)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class