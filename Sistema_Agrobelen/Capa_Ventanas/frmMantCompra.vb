Imports Capa_Datos
Imports Capa_Entidades
Public Class frmMantCompra
    Private producto As Integer = -1
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
    Private Sub frmMantCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAlmacenes()
        cargarEmpleadosActivos()
        CboxPago.SelectedIndex = 0
        cmbTipoComprobante.SelectedIndex = 0
    End Sub

    Private Sub btnAgregarProductos_Click(sender As Object, e As EventArgs) Handles btnAgregarProductos.Click
        If CInt(cmbSucursal.SelectedValue.ToString) <> 0 Then
            sucursalAux = CInt(cmbSucursal.SelectedValue.ToString)
            bandGlobal = 1
            Do While bandGlobal = 1
                Dim ventana As New frmAñadirProductos
                ventana.ShowDialog()
                dgvDatos.DataSource = Nothing 'Libero de Datos
                dgvDatos.DataSource = listaProductosAux
                If listaProductosAux.Count = 1 Then
                    cmbSucursal.Enabled = False
                End If
                modificarMontos()
            Loop

        Else
            MsgBox("Seleccione Sucursal", 16)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADOUsuario As New clsUsuarioADO
        Dim objUsuarioAux As clsUsuario
        Dim objADO As New clsCompraADO
        Dim objProducto As New clsProductoADO
        Dim nombreAlmacenAux As String
        Dim obj As clsCompra
        Dim objKardex As clsKardex
        Dim objADOInventario As New clsInventarioADO
        Dim listaDetalles As New List(Of clsDetalleCompra)
        Dim listaInventarios As New List(Of clsInventario)
        Dim band As Integer = 0
        Try
            For j = 0 To dgvDatos.Rows.Count - 1
                If dgvDatos.Rows(j).Cells(3).Value = 0 Then
                    MsgBox("Del Producto " & dgvDatos.Rows(j).Cells(2).Value.ToString & " se esta Pidiendo Cantidad 0, Verifique Cantidad o Elimine Producto de la Tabla", 16)
                Else
                    band = 1
                End If
            Next
            If band = 1 Then
                If txtSerie.Text.Length > 0 And txtNumero.Text.Length > 0 And
                                cmbTipoComprobante.SelectedIndex > 0 And CboxPago.SelectedIndex > 0 And txtIdProveedor.Text.Length > 0 Then
                    objUsuarioAux = objADOUsuario.buscarUsuarioXempleado(cmbEmpleado.SelectedValue.ToString)
                    If CboxPago.SelectedIndex = 1 Then
                        obj = New clsCompra(0, dtpFechaEmision.Value, CboxPago.SelectedItem, CDbl(txtTotal.Text), CDbl(txtIGV.Text),
                          txtNumero.Text, txtSerie.Text, CDbl(txtStotal.Text), cmbTipoComprobante.SelectedItem, 0,
                          dtpFechaEmision.Value, txtIdProveedor.Text, objUsuarioAux.idEmpleado, objUsuarioAux.idUsuario)
                    Else
                        Dim fecha As Date
                        fecha = dtpFechaEmision.Value.AddDays(txtDias.Text)
                        obj = New clsCompra(0, dtpFechaEmision.Value, CboxPago.SelectedItem, CDbl(txtTotal.Text), CDbl(txtIGV.Text),
                          txtNumero.Text, txtSerie.Text, CDbl(txtStotal.Text), cmbTipoComprobante.SelectedItem, CInt(txtDias.Text),
                          fecha, txtIdProveedor.Text, objUsuarioAux.idEmpleado, objUsuarioAux.idUsuario)
                    End If
                    For i = 0 To dgvDatos.Rows.Count - 1
                        Dim objInventario As clsInventario
                        Dim objDetalles As clsDetalleCompra
                        Dim objProductoAux As clsProducto
                        objProductoAux = objProducto.buscarProducto(CInt(dgvDatos.Rows(i).Cells(0).Value))
                        objProductoAux.costo = CDbl(dgvDatos.Rows(i).Cells(4).Value)
                        objProducto.modificarProducto_PA(objProductoAux)
                        objInventario = objADOInventario.buscarInventario(CInt(dgvDatos.Rows(i).Cells(0).Value), CInt(cmbSucursal.SelectedValue))
                        objDetalles = New clsDetalleCompra(0, CInt(dgvDatos.Rows(i).Cells(3).Value), CDbl(dgvDatos.Rows(i).Cells(5).Value),
                                        0, CInt(dgvDatos.Rows(i).Cells(0).Value))
                        listaInventarios.Add(objInventario)
                        listaDetalles.Add(objDetalles)
                    Next
                    Dim docRef As String
                    docRef = txtSerie.Text & txtNumero.Text
                    nombreAlmacenAux = cmbSucursal.Text
                    objKardex = New clsKardex(0, dtpFechaEmision.Value, "ENTRADA", "COMPRA", nombreAlmacenAux, 0, 0, CInt(cmbSucursal.SelectedValue), docRef, cmbEmpleado.Text, cmbSucursal.Text, 0)
                    objADO.agregarCompra_PA(obj, listaDetalles, listaInventarios, objKardex)
                    MsgBox("COMPRA AGREGADA", 64)
                    Me.Close()
                    listaProductosAux.Clear()
                Else
                    MsgBox("Falta Completar Campos Obligatorios", 16)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Hice Cambio
    Private Sub CboxPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboxPago.SelectedIndexChanged
        If CboxPago.SelectedIndex = 0 Then
            txtDias.Enabled = False
        Else
            If CboxPago.SelectedIndex = 1 Then
                txtDias.Enabled = False
            Else
                txtDias.Enabled = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim objAdo As New clsProveedorADO
        proveedorGlobal = objAdo.buscarProveedor(txtIdProveedor.Text)
        If IsNothing(proveedorGlobal) Then
            Dim _valor As Integer
            _valor = MsgBox("PROVEEDOR NO REGISTRADO, ¿DESEA REGISTRAR?", 4)
            If _valor = 6 Then
                Dim ventana As New frmMantProveedor
                ventana.Show()
            Else
                txtNombre.Text = ""
            End If
        Else
            txtNombre.Text = proveedorGlobal.nombre
            If proveedorGlobal.tipoDocumento = "P. Juridica" Then
                rbtnJuridica.Checked = True
                rbtnNatural.Checked = False
            Else
                rbtnNatural.Checked = True
                rbtnJuridica.Checked = False
            End If
            txtDireccion.Text = proveedorGlobal.direccion
        End If
        proveedorGlobal = Nothing
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        listaProductosAux.Clear()
        Me.Close()
    End Sub
    Public Sub modificarMontos()
        Dim suma As Double = 0
        For i = 0 To dgvDatos.Rows.Count - 1
            suma = suma + CDbl(dgvDatos.Rows(i).Cells(5).Value.ToString)
        Next
        txtStotal.Text = Math.Round((suma / 1.18), 2).ToString
        txtIGV.Text = Math.Round(((suma / 1.18) * 0.18), 2).ToString
        txtTotal.Text = suma.ToString
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If producto <> -1 Then
            For i = 0 To listaProductosAux.Count - 1
                If listaProductosAux.Item(i).ID = producto Then
                    listaProductosAux.Remove(listaProductosAux.Item(i))
                    dgvDatos.DataSource = Nothing
                    dgvDatos.DataSource = listaProductosAux
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
    End Sub
    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        If dgvDatos.Rows.Count > 0 Then
            producto = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub txtDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDias.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtIdProveedor.Text = ""
        txtNombre.Text = ""
        rbtnJuridica.Checked = False
        rbtnNatural.Checked = False
        txtDireccion.Text = ""
        proveedorGlobal = Nothing
    End Sub
End Class