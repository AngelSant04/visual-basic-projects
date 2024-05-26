Imports Capa_Datos
Imports Capa_Entidades
Public Class frmMantCliente
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmMantCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If clienteGlobal Is Nothing Then
            txtIdCliente.Enabled = True
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
        Else
            txtIdCliente.Text = clienteGlobal.idCliente
            txtIdCliente.Enabled = False
            txtNombres.Text = clienteGlobal.nombres
            txtPaterno.Text = clienteGlobal.apPaterno
            txtMaterno.Text = clienteGlobal.apMaterno
            If rbtnNatural.Text = clienteGlobal.tipoDocumento Then
                rbtnNatural.Select()
            Else
                rbtnJuridica.Select()
            End If
            txtTelefono.Text = clienteGlobal.telefono
            txtCorreo.Text = clienteGlobal.correo
            txtDireccion.Text = clienteGlobal.direccion
            clienteGlobal = Nothing
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADO As New clsClienteADO
        Dim obj As clsCliente
        Try
            ''VALIDO QUE NINGUN DATO ESTE INCOMPLETO ( NO HAYA VACIOS)
            If txtIdCliente.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtPaterno.Text.Trim.Length > 0 And
                txtMaterno.Text.Trim.Length > 0 And rbtnNatural.Checked = True Or rbtnJuridica.Checked = True Then
                If rbtnNatural.Checked = True Then
                    ''CREO UN OBJETO CLIENTE COMO PERSONA NATURAL
                    obj = New clsCliente(txtIdCliente.Text, txtNombres.Text, txtPaterno.Text, txtMaterno.Text,
                                         txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, rbtnNatural.Text)
                    ''AGREGO EL OBJETO CLIENTE A LA BASE DE DATOS MEDIANTE UN PROCEDIMIENTO ALMACENADO
                    objADO.agregarCliente_PA(obj)
                    '' MENSAJE DE REGISTRO EXITOSO
                    MsgBox("Cliente Agregado", 64)
                    Me.Close()
                Else
                    ''CREO UN OBJETO CLIENTE COMO PERSONA JURIDICA 
                    obj = New clsCliente(txtIdCliente.Text, txtNombres.Text, txtPaterno.Text, txtMaterno.Text,
                                         txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, rbtnJuridica.Text)
                    objADO.agregarCliente_PA(obj)
                    '' MENSAJE DE REGISTRO EXITOSO
                    MsgBox("Cliente Agregado", 64)
                    Me.Close()
                End If
            Else
                '' MENSAJE DE CAMPOS VACIOS , NO SE CUMPLIO LA VALIDACION INICIAL
                MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objADO As New clsClienteADO
        Dim obj As clsCliente
        Try
            If txtIdCliente.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtPaterno.Text.Trim.Length > 0 And
                txtMaterno.Text.Trim.Length > 0 And rbtnNatural.Checked = True Or rbtnJuridica.Checked = True Then
                If rbtnNatural.Checked = True Then
                    obj = New clsCliente(txtIdCliente.Text, txtNombres.Text, txtPaterno.Text, txtMaterno.Text,
                                         txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, rbtnNatural.Text)
                    objADO.modificarCliente_PA(obj)
                    MsgBox("Cliente Modificado", 64)
                    Me.Close()
                Else
                    obj = New clsCliente(txtIdCliente.Text, txtNombres.Text, txtPaterno.Text, txtMaterno.Text,
                                         txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, rbtnJuridica.Text)
                    objADO.modificarCliente_PA(obj)
                    MsgBox("Cliente Modificado", 64)
                    Me.Close()
                End If
            Else
                MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class