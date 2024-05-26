Imports CapaDatos
Imports CapaEntidades

Public Class frmMantenimientoEmpleados

    Private Sub frmMantenimientoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProfesion.SelectedIndex = 0
        cargarDatos()
        cargarProfesiones()
    End Sub

    Private Sub cargarDatos()
        Dim objAdo As New clsEmpleadoADO
        Dim dt As DataTable

        Try
            dt = objAdo.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cargarProfesiones()
        Dim objAdo As New clsProfesionADO
        Dim dt As DataTable

        Try
            dt = objAdo.listado
            cmbProfesion.DataSource = dt
            cmbProfesion.DisplayMember = "descripcion"
            cmbProfesion.ValueMember = "idProfesion"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub limpiar()
        txtDNI.Text = ""
        txtNombres.Text = ""
        txtApPaterno.Text = ""
        txtApMaterno.Text = ""
        txtUsuario.Text = ""
        txtClave.Text = ""
        cmbProfesion.SelectedIndex = 0
        chkEstado.Checked = False
        btnModificar.Enabled = False
        btnRegistrar.Enabled = True
        txtDNI.Enabled = True
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objADO As New clsEmpleadoADO
        Dim obj As clsEmpleado

        Try
            'Validar el ingreso de datos
            If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtApPaterno.Text.Trim.Length > 0 And
            txtApMaterno.Text.Trim.Length > 0 And txtUsuario.Text.Trim.Length > 0 And txtClave.Text.Trim.Length > 0 Then
                obj = New clsEmpleado(txtDNI.Text, txtNombres.Text, txtApPaterno.Text,
                                  txtApMaterno.Text, dtpFecha.Value, chkEstado.Checked,
                                  txtUsuario.Text, txtClave.Text, CInt(cmbProfesion.SelectedValue), 2)
                'objADO.agregar(obj)
                objADO.agregar_PA(obj)
                MsgBox("Empleado Agregado")
                limpiar()
                cargarDatos()
            Else
                MsgBox("Debe llenar todos los campos")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objADO As New clsEmpleadoADO
        Dim obj As clsEmpleado

        Try
            'Validar el ingreso de datos
            If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtApPaterno.Text.Trim.Length > 0 And
            txtApMaterno.Text.Trim.Length > 0 And txtUsuario.Text.Trim.Length > 0 And txtClave.Text.Trim.Length > 0 Then
                obj = New clsEmpleado(txtDNI.Text, txtNombres.Text, txtApPaterno.Text,
                                  txtApMaterno.Text, dtpFecha.Value, chkEstado.Checked,
                                  txtUsuario.Text, txtClave.Text, CInt(cmbProfesion.SelectedValue), 1)
                objADO.modificar(obj)
                MsgBox("Empleado Modificado")
                limpiar()
                cargarDatos()
            Else
                MsgBox("Debe llenar todos los campos")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        txtDNI.Text = dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString
        txtNombres.Text = dgvDatos.SelectedRows().Item(0).Cells(1).Value.ToString
        txtApPaterno.Text = dgvDatos.SelectedRows().Item(0).Cells(2).Value.ToString
        txtApMaterno.Text = dgvDatos.SelectedRows().Item(0).Cells(3).Value.ToString
        dtpFecha.Value = CDate(dgvDatos.SelectedRows().Item(0).Cells(4).Value.ToString)
        chkEstado.Checked = CInt(dgvDatos.SelectedRows().Item(0).Cells(5).Value)
        txtUsuario.Text = dgvDatos.SelectedRows().Item(0).Cells(6).Value.ToString
        txtClave.Text = dgvDatos.SelectedRows().Item(0).Cells(7).Value.ToString
        cmbProfesion.SelectedIndex = CInt(dgvDatos.SelectedRows().Item(0).Cells(8).Value) - 1
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        txtDNI.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub
End Class