Imports Capa_Datos
Imports Capa_Entidades
Public Class fmrMantEmpleado
    Private Sub cargarCategoriaUsario()
        Dim objADO As New clsCategoriaUsuarioADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            cmbCategoriaUsuario.DataSource = dt
            cmbCategoriaUsuario.DisplayMember = "descripcion"
            cmbCategoriaUsuario.ValueMember = "idCategoriaUsuario"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADO As New clsEmpleadoADO
        Dim objADO2 As New clsUsuarioADO
        Dim obj As clsEmpleado
        Dim obj2 As clsUsuario
        Dim cad As String
        Try
            If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And
               txtPaterno.Text.Trim.Length > 0 And txtMaterno.Text.Trim.Length > 0 And txtSueldo.Text.Trim.Length > 0 And cmbEstado.SelectedIndex > 0 And
                 txtUsuario.Text.Trim.Length > 0 And txtClave.Text.Trim.Length > 0 Then
                cad = "0E" & txtDNI.Text
                obj = New clsEmpleado(cad, txtNombres.Text, txtPaterno.Text,
                                      txtMaterno.Text, dtpFechaIngreso.Value, CDbl(txtSueldo.Text))
                obj2 = New clsUsuario(cad, txtClave.Text, CInt(cmbCategoriaUsuario.SelectedValue), cmbEstado.Text, txtUsuario.Text)
                objADO.agregarEmpleado_PA(obj)
                objADO2.agregarUsuario_PA(obj2)
                MsgBox("Empleado y Usuario Agregado")
                Me.Close()
            Else
                MsgBox("Falta Completar Campos", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub fmrMantEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEstado.SelectedIndex = 0
        cargarCategoriaUsario()
        If empleadoGlobal Is Nothing Then
            txtDNI.Enabled = True
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
        Else
            Dim DNI = empleadoGlobal.idEmpleado.Substring(2, 8)
            Dim objADO As New clsUsuarioADO
            Dim obj As clsUsuario
            obj = objADO.buscarUsuarioXempleado(empleadoGlobal.idEmpleado)
            txtDNI.Text = DNI
            txtDNI.Enabled = False
            txtNombres.Text = empleadoGlobal.nombres
            txtPaterno.Text = empleadoGlobal.apPaterno
            txtMaterno.Text = empleadoGlobal.apMaterno
            dtpFechaIngreso.Value = empleadoGlobal.fechaIngreso
            txtSueldo.Text = empleadoGlobal.sueldo.ToString
            cmbEstado.SelectedItem = obj.estado
            txtUsuario.Text = obj.idUsuario
            txtClave.Text = obj.clave
            cmbCategoriaUsuario.SelectedItem = obj.idCategoriaUsuario.ToString
            empleadoGlobal = Nothing
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objADO As New clsEmpleadoADO
        Dim objADO2 As New clsUsuarioADO
        Dim obj As clsEmpleado
        Dim obj2 As clsUsuario
        Dim cad As String
        Try
            If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And
               txtPaterno.Text.Trim.Length > 0 And txtMaterno.Text.Trim.Length > 0 And txtSueldo.Text.Trim.Length > 0 And cmbEstado.SelectedIndex > 0 And
                 txtUsuario.Text.Trim.Length > 0 And txtClave.Text.Trim.Length > 0 Then
                cad = "0E" & txtDNI.Text
                obj = New clsEmpleado(cad, txtNombres.Text, txtPaterno.Text,
                                      txtMaterno.Text, dtpFechaIngreso.Value, CDbl(txtSueldo.Text))
                obj2 = New clsUsuario(cad, txtClave.Text, CInt(cmbCategoriaUsuario.SelectedValue), cmbEstado.Text, txtUsuario.Text)
                objADO.modificarEmpleado_PA(obj)
                objADO2.modificarUsuario_PA(obj2)
                MsgBox("Empleado y Usuario Modificado")
                Me.Close()
            Else
                MsgBox("Falta Completar Campos", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class