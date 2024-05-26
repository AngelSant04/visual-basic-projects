Imports Capa_Datos
Imports Capa_Entidades
Public Class frmRegistrarTarjeta
    Private Sub cargarVacunas()
        Dim objADO As New clsVacunaADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            cmbVacuna.DataSource = dt
            cmbVacuna.DisplayMember = "empresa"
            cmbVacuna.ValueMember = "idVacuna"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub cargarDatos()
        Dim objADO As New clsTarjetaADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objADO As New clsTarjetaADO
        Dim obj As clsTarjetaVacuna
        Dim objAux As clsTarjetaVacuna
        Try
            If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 Then
                objAux = objADO.buscarTarjeta(txtDNI.Text)
                If objAux Is Nothing Then
                    obj = New clsTarjetaVacuna(txtDNI.Text, 1, dtpFecha.Value, CInt(cmbVacuna.SelectedValue))
                    objADO.agregarTarjeta_PA(obj)
                    MsgBox("Tarjeta Agregada")
                    txtDNI.Enabled = True
                    txtNombres.Enabled = True
                    cargarDatos()
                    'limpiar()
                Else
                    'objADO.modificarDosisTarjeta_PA(txtDNI.Text)
                    MsgBox("Tarjeta Concluida")
                    txtDNI.Enabled = True
                    txtNombres.Enabled = True
                    cargarDatos()
                    'limpiar()
                End If
            Else
                MsgBox("Falta Ingresar Valores")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmRegistrarTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarVacunas()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objADO As New clsCiudadanoADO
        Dim objADOT As New clsTarjetaADO
        Dim objAux As clsTarjetaVacuna
        Dim obj As clsCiudadano
        Try
            If txtDNI.Text.Trim.Length > 0 Then
                obj = objADO.buscarCiudadano(txtDNI.Text.ToString)
                'objAux = objADOT.buscarTarjeta(txtDNI.Text.ToString)
                If obj Is Nothing Then
                    MsgBox("Ciudadano No Encontrado")
                Else
                    txtDNI.Text = obj.DNI
                    txtNombres.Text = obj.nombres & " " & obj.apPaterno & " " & obj.apPaterno
                    'txtDosis.Text = objAux.numDosis.ToString
                    txtDNI.Enabled = False
                    txtNombres.Enabled = False
                    txtDosis.Enabled = False
                End If
            Else
                MsgBox("Falta Ingresar DNI")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class