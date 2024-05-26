Imports Libreria_Clases
Public Class frmRegistraVenta

    Private DNIAux As String
    Private posEmpleado As Integer

    Private Sub frmRegistraVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cmbServicio.SelectedIndex = 0
        cmbTipoVenta.SelectedIndex = 0
        cmbDNI.SelectedIndex = 0
        For i = 0 To coleccionEmpleados.getTotal - 1
            cmbDNI.Items.Add(coleccionEmpleados.getEmpleado(i).getDNIyNombre.ToString)
        Next
        txtNumero.Text = (coleccionVentas.getTotal + 1).ToString
    End Sub
    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionVentas.getTotal - 1
            lstDatos.Items.Add(coleccionVentas.getVenta(i).mostrar)
        Next
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim obj As clsVentaCelular
        Dim objInternet As clsServicioInternet
        Dim objCable As clsServicioCable

        If cmbTipoVenta.SelectedIndex = 1 Then
            If cmbTipoVenta.SelectedIndex <> 0 And txtMonto.Text.Trim.Length > 0 And txtDescripcion.Text.Trim.Length > 0 And txtMarca.Text.Trim.Length > 0 And txtMeses.Text.Trim.Length > 0 And cmbDNI.SelectedIndex <> 0 Then
                obj = New clsVentaCelular(CInt(txtNumero.Text), cmbTipoVenta.Text, CDbl(txtMonto.Text), txtDescripcion.Text, txtMarca.Text, CInt(txtMeses.Text))
                coleccionVentas.agregar(obj)
                MsgBox("Venta Registrada")
                coleccionEmpleados.getEmpleado(posEmpleado).agregarVenta(obj)
                limpiar()
                cargarDatos()
            Else
                MsgBox("Debe Completar todos los Datos")
            End If
        Else
            If cmbServicio.SelectedIndex = 1 Then
                If cmbTipoVenta.SelectedIndex <> 0 And txtMonto.Text.Trim.Length > 0 And cmbServicio.SelectedIndex <> 0 And txtGigas.Text.Trim.Length > 0 And cmbDNI.SelectedIndex <> 0 Then
                    objInternet = New clsServicioInternet(CInt(txtNumero.Text), cmbTipoVenta.Text, CDbl(txtMonto.Text), cmbServicio.Text, CInt(txtGigas.Text))
                    coleccionVentas.agregar(objInternet)
                    MsgBox("Venta Registrada")
                    coleccionEmpleados.getEmpleado(posEmpleado).agregarVenta(objInternet)
                    limpiar()
                    cargarDatos()
                Else
                    MsgBox("Debe Completar todos los Datos")
                End If
            Else
                If cmbTipoVenta.SelectedIndex <> 0 And txtMonto.Text.Trim.Length > 0 And cmbServicio.SelectedIndex <> 0 And txtCanales.Text.Trim.Length > 0 And txtPuntos.Text.Trim.Length > 0 And cmbDNI.SelectedIndex <> 0 Then
                    objCable = New clsServicioCable(CInt(txtNumero.Text), cmbTipoVenta.Text, CDbl(txtMonto.Text), cmbServicio.Text, txtCanales.Text, txtPuntos.Text)
                    coleccionVentas.agregar(objCable)
                    MsgBox("Venta Registrada")
                    coleccionEmpleados.getEmpleado(posEmpleado).agregarVenta(objCable)
                    limpiar()
                    cargarDatos()
                Else
                    MsgBox("Debe Completar todos los Datos")
                End If
            End If
        End If
    End Sub

    Private Sub cmbTipoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoVenta.SelectedIndexChanged
        If cmbTipoVenta.SelectedIndex = 0 Then
            gboCelular.Enabled = False
            gboConectividad.Enabled = False
        Else
            If cmbTipoVenta.SelectedIndex = 1 Then
                gboCelular.Enabled = True
                gboConectividad.Enabled = False
            Else
                gboCelular.Enabled = False
                gboConectividad.Enabled = True
            End If
        End If
    End Sub

    Private Sub limpiar()
        cmbTipoVenta.SelectedIndex = 0
        txtMonto.Clear()
        txtNumero.Text = (coleccionVentas.getTotal + 1).ToString
        gboCelular.Enabled = False
        txtDescripcion.Clear()
        txtMarca.Clear()
        txtMeses.Clear()
        gboConectividad.Enabled = False
        txtGigas.Clear()
        txtCanales.Clear()
        txtPuntos.Clear()
        cmbDNI.SelectedIndex = 0
        cmbServicio.SelectedIndex = 0
        txtNombres.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
    End Sub

    Private Sub cmbServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServicio.SelectedIndexChanged
        If cmbServicio.SelectedIndex = 0 Then
            gboCable.Enabled = False
            gboInternet.Enabled = False
        Else
            If cmbServicio.SelectedIndex = 1 Then
                gboInternet.Enabled = True
                gboCable.Enabled = False
            Else
                gboInternet.Enabled = False
                gboCable.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDNI.SelectedIndexChanged
        For i = 0 To coleccionEmpleados.getTotal - 1
            If coleccionEmpleados.getEmpleado(i).getDNIyNombre = cmbDNI.SelectedItem.ToString Then
                txtNombres.Text = coleccionEmpleados.getEmpleado(i).getNombres
                txtDireccion.Text = coleccionEmpleados.getEmpleado(i).getDisrtito
                txtTelefono.Text = coleccionEmpleados.getEmpleado(i).getTelefono
                posEmpleado = i
            End If
        Next
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class