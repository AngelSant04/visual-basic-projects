Imports Capa_Datos
Imports Capa_Entidades
Public Class frmVenta

    Dim producto As Integer = -1
    Dim cliente As clsCliente = Nothing
    Private Sub cargarTalonarios()
        Dim objADO As New clsTalonarioADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            cmbTalonario.DataSource = dt
            cmbTalonario.DisplayMember = "tipoTalonario"
            cmbTalonario.ValueMember = "serieTalonario"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub cargarAlmacenes()
        Dim objADO As New clsAlmacenADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoCombo
            cmbSucursal.DataSource = dt
            cmbSucursal.DisplayMember = "sucursal"
            cmbSucursal.ValueMember = "idAlmacen"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub cargarEmpleadosActivos()
        Dim objADO As New clsEmpleadoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoActivo
            cmbEmpleado.DataSource = dt
            cmbEmpleado.DisplayMember = "NOMBRES COMPLETOS"
            cmbEmpleado.ValueMember = "ID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub modificarMontos()
        Dim suma As Double = 0
        Dim subtotal As Double
        Dim igv As Double
        For i = 0 To dgvDatos.Rows.Count - 1
            suma = suma + CDbl(dgvDatos.Rows(i).Cells(4).Value.ToString)
        Next
        subtotal = suma / 1.18
        igv = subtotal * 0.18
        txtStotal.Text = Math.Round(subtotal, 2).ToString
        txtIGV.Text = Math.Round(igv, 2).ToString
        txtTotal.Text = (subtotal + igv).ToString
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        listaProductosAuxVenta.Clear()
        Me.Close()

    End Sub

    Private Sub btnAgregarProductos_Click(sender As Object, e As EventArgs) Handles btnAgregarProductos.Click
        sucursalAux = CInt(cmbSucursal.SelectedValue.ToString)
        bandGlobal = 1
        Do While bandGlobal = 1
            Dim ventana As New frmAnadirProductoVenta
            ventana.ShowDialog()
            dgvDatos.DataSource = Nothing
            dgvDatos.DataSource = listaProductosAuxVenta
            If listaProductosAuxVenta.Count = 1 Then
                cmbSucursal.Enabled = False
            End If
            modificarMontos()
        Loop
    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAlmacenes()
        cargarEmpleadosActivos()
        cargarTalonarios()
        txtSerie.Text = cmbTalonario.SelectedValue.ToString
    End Sub

    Private Sub cmbTalonario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTalonario.SelectedIndexChanged
        Dim obj As New clsVentaADO
        Dim numero As String
        txtSerie.Text = cmbTalonario.SelectedValue.ToString
        numero = obj.contarVentas(cmbTalonario.SelectedIndex + 1) + 1
        numero = numero.PadLeft(8, "0")
        txtNumero.Text = numero
    End Sub

    Private Sub cmbPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPago.SelectedIndexChanged
        If cmbPago.SelectedIndex = 0 Or cmbPago.SelectedIndex = 1 Then
            txtDias.Enabled = False
            txtDias.Text = 0
        Else
            txtDias.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim obj As New clsClienteADO
        Dim valor As Integer
        cliente = obj.buscarCliente(txtIdentificacion.Text.Trim)
        If IsNothing(cliente) Then
            valor = MsgBox("CLIENTE NO REGISTRADO. ¿DESEA REGISTRARLO?", 4)
            If valor = 6 Then
                Dim ventana As New frmMantCliente
                cliente = Nothing
                ventana.ShowDialog()
            End If
        Else
            txtNombre.Text = cliente.nombres & " " & cliente.apPaterno & " " & cliente.apMaterno
            txtIdentificacion.Text = cliente.idCliente
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtIdentificacion.Clear()
        txtNombre.Clear()
        cliente = Nothing
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDatos.RowCount >= 1 Then
            If producto <> -1 Then
                For i = 0 To listaProductosAuxVenta.Count - 1
                    If listaProductosAuxVenta.Item(i).ID = producto Then
                        listaProductosAuxVenta.Remove(listaProductosAuxVenta.Item(i))
                        dgvDatos.DataSource = Nothing
                        dgvDatos.DataSource = listaProductosAuxVenta
                        modificarMontos()
                        If dgvDatos.Rows.Count = 0 Then
                            cmbSucursal.Enabled = True
                        Else
                            cmbSucursal.Enabled = False
                        End If
                        Exit For
                    End If

                Next
            End If
        Else
            MsgBox("NO HAY PRODUCTOS PARA ELIMINAR", 16)
        End If


    End Sub



    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        If dgvDatos.Rows.Count > 0 Then
            producto = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADOUsuario As New clsUsuarioADO
        Dim objUsuarioAux As clsUsuario
        Dim objADO As New clsVentaADO
        Dim obj As clsVenta
        Dim objC As clsComprobante
        Dim objKardex As clsKardex
        Dim objADOInventario As New clsInventarioADO
        Dim listaDetalles As New List(Of clsDetalleVenta)
        Dim listaInventarios As New List(Of clsInventario)
        Dim fechaPago As Date
        Dim diasCredito As Integer

        Try

            If cmbPago.SelectedIndex > 0 And Not IsNothing(cliente) Then
                objUsuarioAux = objADOUsuario.buscarUsuarioXempleado(cmbEmpleado.SelectedValue.ToString)
                If cmbPago.SelectedIndex = 1 Then
                    fechaPago = dtpFecha.Value
                    diasCredito = CInt(txtDias.Text)

                Else

                    fechaPago = dtpFecha.Value.AddDays(txtDias.Text)
                    diasCredito = CInt(txtDias.Text)

                End If
                obj = New clsVenta(0, dtpFecha.Value, cmbPago.SelectedItem, CDbl(txtTotal.Text), CDbl(txtIGV.Text), CDbl(txtStotal.Text),
                                  cliente.idCliente, cmbEmpleado.SelectedValue, 1, diasCredito, fechaPago)
                For i = 0 To dgvDatos.Rows.Count - 1
                    Dim objInventario As clsInventario
                    Dim objDetalles As clsDetalleVenta

                    objInventario = objADOInventario.buscarInventario(CInt(dgvDatos.Rows(i).Cells(0).Value.ToString), CInt(cmbSucursal.SelectedValue.ToString))
                    objDetalles = New clsDetalleVenta(0, CInt(dgvDatos.Rows(i).Cells(2).Value.ToString), CInt(dgvDatos.Rows(i).Cells(4).Value.ToString), 0,
                                                      CInt(dgvDatos.Rows(i).Cells(0).Value.ToString))
                    listaInventarios.Add(objInventario)
                    listaDetalles.Add(objDetalles)
                Next
                Dim docref As String
                docref = txtSerie.Text & txtNumero.Text
                objC = New clsComprobante(CInt(txtNumero.Text), cmbTalonario.Text, 0, cmbTalonario.SelectedIndex + 1)
                objKardex = New clsKardex(0, dtpFecha.Value, "SALIDA", "VENTA", cmbSucursal.Text, 0, 0, CInt(cmbSucursal.SelectedValue), docref, cmbEmpleado.Text,
txtNombre.Text, 0)
                objADO.agregarVenta_PA(obj, listaDetalles, listaInventarios, objKardex, objC)
                MsgBox("VENTA AGREGADA", 64)
                    Me.Close()
                    listaProductosAuxVenta.Clear()
                Else
                    MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub txtDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDias.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Class