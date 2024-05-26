Imports Capa_Datos
Imports Capa_Entidades
Public Class frmAgregarVacuna
    Public Sub cargarDatos()
        Dim objADO As New clsVacunaADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub limpiar()
        txtCantidad.Text = ""
        txtEmpresa.Text = ""
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objADO As New clsVacunaADO
        Dim obj As clsVacuna
        Try
            If txtEmpresa.Text.Trim.Length > 0 And txtCantidad.Text.Trim.Length > 0 Then
                obj = New clsVacuna(0, txtEmpresa.Text, txtCantidad.Text, dtpFecha.Value)
                objADO.agregarVacuna_PA(obj)
                MsgBox("Vacuna Agregada")
                cargarDatos()
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmAgregarVacuna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub
End Class