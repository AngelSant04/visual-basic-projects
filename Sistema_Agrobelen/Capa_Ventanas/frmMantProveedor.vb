Imports Capa_Datos
Imports Capa_Entidades
Public Class frmMantProveedor
    Private Sub frmMantProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEstado.SelectedIndex = 0
        If proveedorGlobal Is Nothing Then
            txtRUC.Enabled = True
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
        Else
            txtRUC.Text = proveedorGlobal.idProveedor
            txtRUC.Enabled = False
            txtNombres.Text = proveedorGlobal.nombre
            If rbtnNatural.Text = proveedorGlobal.tipoDocumento Then
                rbtnNatural.Select()
            Else
                rbtnJuridica.Select()
            End If
            txtDireccion.Text = proveedorGlobal.direccion
            txtCorreo.Text = proveedorGlobal.correo
            txtTelefono.Text = proveedorGlobal.telefono
            cmbEstado.SelectedItem = proveedorGlobal.estado
            ''VACIADO DE DATOS
            proveedorGlobal = Nothing
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADO As New clsProveedorADO
        Dim obj As clsProveedor
        Try
            If txtRUC.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And
               txtDireccion.Text.Trim.Length > 0 And cmbEstado.SelectedIndex > 0 And rbtnNatural.Checked = True Or rbtnJuridica.Checked = True Then
                If rbtnNatural.Checked = True Then
                    obj = New clsProveedor(txtRUC.Text, txtNombres.Text, rbtnNatural.Text,
                                          txtDireccion.Text, txtCorreo.Text, txtTelefono.Text, cmbEstado.SelectedItem)
                    objADO.agregarProveedor_PA(obj)
                    MsgBox("Proveedor Agregado", 64)
                    Me.Close()
                Else
                    obj = New clsProveedor(txtRUC.Text, txtNombres.Text, rbtnJuridica.Text,
                                          txtDireccion.Text, txtCorreo.Text, txtTelefono.Text, cmbEstado.SelectedItem)
                    objADO.agregarProveedor_PA(obj)
                    MsgBox("Proveedor Agregado", 64)
                    Me.Close()
                End If
            Else
                MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objADO As New clsProveedorADO
        Dim obj As clsProveedor
        Try
            If txtRUC.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And
               txtDireccion.Text.Trim.Length > 0 And cmbEstado.SelectedIndex > 0 And rbtnNatural.Checked = True Or rbtnJuridica.Checked = True Then
                If rbtnNatural.Checked = True Then
                    obj = New clsProveedor(txtRUC.Text, txtNombres.Text, rbtnNatural.Text,
                                          txtDireccion.Text, txtCorreo.Text, txtTelefono.Text, cmbEstado.SelectedItem)
                    objADO.modificarProveedor_PA(obj)
                    MsgBox("Proveedor Modificado", 64)
                    Me.Close()
                Else
                    obj = New clsProveedor(txtRUC.Text, txtNombres.Text, rbtnJuridica.Text,
                                          txtDireccion.Text, txtCorreo.Text, txtTelefono.Text, cmbEstado.SelectedItem)
                    objADO.modificarProveedor_PA(obj)
                    MsgBox("Proveedor Modificado", 64)
                    Me.Close()
                End If
            Else
                MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class