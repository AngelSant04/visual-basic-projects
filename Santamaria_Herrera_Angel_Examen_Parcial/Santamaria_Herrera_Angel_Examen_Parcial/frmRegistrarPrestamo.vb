Imports Libreria_Clases
Public Class frmRegistrarPrestamo
    Private Sub frmRegistrarPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cmbTipoPrestamo.SelectedIndex = 0
        cmbDNIPP.SelectedIndex = 0
        cmbDNIPE.SelectedIndex = 0
        cmbMotivoPE.SelectedIndex = 0
        cmbMotivoPP.SelectedIndex = 0
        cmbGarantia.SelectedIndex = 0
        cmbTipoEstudio.SelectedIndex = 0
        cmbTipoConstruccion.SelectedIndex = 0
        cmbTipoEmprendimiento.SelectedIndex = 0
        For i = 0 To coleccionClientes.Count - 1
            If CType(coleccionClientes.Item(i), clsCliente).getTipo = "Persona Natural" Then
                cmbDNIPP.Items.Add(CType(coleccionClientes.Item(i), clsCliente).mosrtarDNIyNombre.ToString)
            Else
                cmbDNIPE.Items.Add(CType(coleccionClientes.Item(i), clsCliente).mosrtarDNIyNombre.ToString)
            End If
        Next
    End Sub
    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionPrestamos.Count - 1
            lstDatos.Items.Add(coleccionPrestamos.Item(i).mostrar)
        Next
    End Sub

    Private Sub cmbTipoPrestamo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPrestamo.SelectedIndexChanged
        If cmbTipoPrestamo.SelectedIndex = 0 Then
            gboPP.Enabled = False
            gboPE.Enabled = False
        Else
            If cmbTipoPrestamo.SelectedIndex = 1 Then
                gboPP.Enabled = True
                txtCapital.Enabled = False
                gboPE.Enabled = False
            Else
                gboPP.Enabled = False
                gboPE.Enabled = True
                cmbTipoConstruccion.Enabled = False
                cmbTipoEstudio.Enabled = False
                cmbTipoEmprendimiento.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objEmprendimiento As clsPrestamoPersonalEmprendimientos
        Dim objCasa As clsPrestamoPersonalAmpliacion
        Dim objEstudio As clsPrestamoPersonalEstudios
        Dim objPrestamoEmpresa As clsPrestamoEmpresarial

        If cmbTipoPrestamo.SelectedIndex = 1 Then
            If txtMonto.Text.Trim.Length > 0 And txtCodigo.Text.Trim.Length > 0 And txtDevolucion.Text.Trim.Length > 0 And txtInteres.Text.Trim.Length > 0 Then
                If cmbMotivoPP.SelectedIndex = 1 Then
                    objEstudio = New clsPrestamoPersonalEstudios(cmbDNIPP.Text, txtCodigo.Text, DtpFecha.Value, CDbl(txtMonto.Text), CInt(txtDevolucion.Text), CInt(txtInteres.Text), cmbMotivoPP.Text, cmbTipoEstudio.Text)
                    coleccionPrestamos.Add(objEstudio)
                    MsgBox("Prestamo agregado")
                    cargarDatos()
                Else
                    If cmbMotivoPP.SelectedIndex = 2 Then
                        objCasa = New clsPrestamoPersonalAmpliacion(cmbDNIPP.Text, txtCodigo.Text, DtpFecha.Value, CDbl(txtMonto.Text), CInt(txtDevolucion.Text), CInt(txtInteres.Text), cmbMotivoPP.Text, cmbTipoConstruccion.Text)
                        coleccionPrestamos.Add(objCasa)
                        MsgBox("Prestamo agregado")
                        cargarDatos()
                    Else
                        objEmprendimiento = New clsPrestamoPersonalEmprendimientos(cmbDNIPP.Text, txtCodigo.Text, DtpFecha.Value, CDbl(txtMonto.Text), CInt(txtDevolucion.Text), CInt(txtInteres.Text), cmbMotivoPP.Text, cmbTipoEmprendimiento.Text)
                        coleccionPrestamos.Add(objEmprendimiento)
                        MsgBox("Prestamo agregado")
                        cargarDatos()
                    End If
                End If
            Else
                MsgBox("Debe completar todos los valores")
            End If
        Else
            objPrestamoEmpresa = New clsPrestamoEmpresarial(cmbDNIPE.Text, txtCodigo.Text, DtpFecha.Value, CDbl(txtMonto.Text), CInt(txtDevolucion.Text), CInt(txtInteres.Text), cmbMotivoPE.Text, cmbGarantia.Text, CInt(txtCapital.Text))
            coleccionPrestamos.Add(objPrestamoEmpresa)
            MsgBox("Prestamo agregado")
            cargarDatos()
        End If
    End Sub

    Private Sub cmbGarantia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGarantia.SelectedIndexChanged
        If cmbGarantia.SelectedIndex = 3 Then
            txtCapital.Enabled = True
        Else
            txtCapital.Enabled = False
        End If
    End Sub

    Private Sub cmbMotivoPP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMotivoPP.SelectedIndexChanged
        If cmbMotivoPE.SelectedIndex = 0 Then
            cmbTipoEstudio.Enabled = False
            cmbTipoConstruccion.Enabled = False
            cmbTipoEmprendimiento.Enabled = False
        Else
            If cmbMotivoPE.SelectedIndex = 1 Then
                cmbTipoEstudio.Enabled = True
            Else
                If cmbMotivoPE.SelectedIndex = 2 Then
                    cmbTipoConstruccion.Enabled = True
                Else
                    cmbTipoEmprendimiento.Enabled = True
                End If
            End If
        End If

    End Sub
End Class