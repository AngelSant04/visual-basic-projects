Imports Capa_Datos
Imports Capa_Entidades
Public Class frmModificarVenta
    Protected Sub cargarDatos()
        Dim objADO As New clsVentaADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub frmModificarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class