Imports Capa_Datos
Imports Capa_Entidades
Public Class frmEntrada
    Dim sucurAux As Integer = 1
    Dim _producto As Integer
    Dim _productoElim As Integer
    Dim muestra As clsMuestraAuxMovimiento
    Protected Sub cargarDatosEspecial(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletraVenta(cmbSucur.SelectedValue, texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecialNombre(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombreVenta(cmbSucur.SelectedValue, texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub cargarAlmacen()
        Dim objADO As New clsAlmacenADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoCombo
            cmbSucur.DataSource = dt
            cmbSucur.DisplayMember = "sucursal"
            cmbSucur.ValueMember = "idAlmacen"
            cmbSucursalRes.DataSource = dt
            cmbSucursalRes.DisplayMember = "sucursal"
            cmbSucursalRes.ValueMember = "idAlmacen"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub contarkardex()
        Dim objADO As New clsKardexADO
        Dim contador As Integer
        contador = objADO.contarKardex("ENTRADA")
        txtEntrada.Text = contador + 1
    End Sub
    Private Sub limpiar()
        txtID.Clear()
        txtNombre.Clear()
        txtPrecioRef.Clear()
        txtStock.Clear()
        txtCantidad.Clear()
        txtProductoBuscar.Clear()
    End Sub
    Protected Sub cargarDatos()
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoProductoVenta(sucurAux)
            dgvDatos.DataSource = dt
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
    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAlmacen()
        cmbTipoDocumento.SelectedIndex = 0
        cmbMotivo.SelectedIndex = 0
        cargarEmpleadosActivos()
        cargarDatos()
        contarkardex()
    End Sub
    Private Sub TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProductoBuscar.KeyUp
        Dim valor As String
        Dim band As Integer = 0
        valor = txtProductoBuscar.Text
        If IsNumeric(valor) Then
            band = 1
        End If
        If band = 1 Then
            cargarDatosEspecial(txtProductoBuscar.Text)
        Else
            cargarDatosEspecialNombre(txtProductoBuscar.Text)
        End If
    End Sub
    Private Sub cmbMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMotivo.SelectedIndexChanged
        If cmbMotivo.SelectedIndex <> 1 Then
            cmbSucur.Enabled = False
        Else
            cmbSucur.Enabled = True
        End If
    End Sub
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtPrecioRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioRef.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub cmbSucursalRes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursalRes.SelectedIndexChanged
        sucurAux = cmbSucursalRes.SelectedIndex + 1
        cargarDatos()
    End Sub
    Private Sub cmbTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoDocumento.SelectedIndexChanged
        If cmbTipoDocumento.SelectedIndex = 1 Then
            txtDocumentoRef.Enabled = False
            txtDocumentoRef.Clear()
        Else
            txtDocumentoRef.Enabled = True
        End If
    End Sub
    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        txtID.Text = dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString
        _producto = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        txtNombre.Text = dgvDatos.SelectedRows().Item(0).Cells(1).Value.ToString
        txtPrecioRef.Text = dgvDatos.SelectedRows().Item(0).Cells(2).Value.ToString
        txtStock.Text = dgvDatos.SelectedRows().Item(0).Cells(3).Value.ToString
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cargarDatos()
        limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objADO As New clsInventarioADO
        Dim objADOProducto As New clsProductoADO
        Dim band As Integer = 0
        productoGlobal = objADOProducto.buscarProducto(_producto)
        If txtCantidad.TextLength > 0 And txtStock.TextLength > 0 Then
            If productoGlobal Is Nothing Then
                MsgBox("SELECCIONE UN PRODUCTO")
            Else
                If CInt(txtCantidad.Text) <= 0 Then
                    MsgBox("CANTIDAD ERRONEA", 16)
                Else
                    muestra = New clsMuestraAuxMovimiento(_producto, productoGlobal.nombre, CInt(txtCantidad.Text), CDbl(txtPrecioRef.Text))
                    For i = 0 To listaProductosAuxMovimiento.Count - 1
                        If listaProductosAuxMovimiento.Item(i).ID = muestra.ID Then
                            band = 1
                            Exit For
                        End If
                    Next
                    If band = 0 Then
                        listaProductosAuxMovimiento.Add(muestra)
                        dgvProductosAgregados.DataSource = Nothing
                        dgvProductosAgregados.DataSource = listaProductosAuxMovimiento
                        If listaProductosAuxMovimiento.Count = 1 Then
                            cmbSucursalRes.Enabled = False
                        End If
                        productoGlobal = Nothing
                        limpiar()
                    Else
                        MsgBox("Producto Ya Se Encuentra Agregado")
                    End If
                End If
            End If
        Else
            MsgBox("CAMPOS INCOMPLETOS", 64)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvProductosAgregados.RowCount >= 1 Then
            If _productoElim >= 1 Then
                For i = 0 To listaProductosAuxMovimiento.Count - 1
                    If listaProductosAuxMovimiento.Item(i).ID = _productoElim Then
                        listaProductosAuxMovimiento.Remove(listaProductosAuxMovimiento.Item(i))
                        dgvProductosAgregados.DataSource = Nothing
                        dgvProductosAgregados.DataSource = listaProductosAuxMovimiento
                        _productoElim = 0
                        If dgvProductosAgregados.Rows.Count = 0 Then
                            cmbSucursalRes.Enabled = True
                        Else
                            cmbSucursalRes.Enabled = False
                        End If
                        limpiar()
                        Exit For
                    End If
                Next
            Else
                MsgBox("NO HAY PRODUCTOS SELECCIONADO", 16)
            End If
        Else
            MsgBox("NO HAY PRODUCTOS PARA ELIMINAR", 16)
        End If
    End Sub
    Private Sub dgvProductosAgregados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductosAgregados.CellClick
        If dgvProductosAgregados.Rows.Count > 0 Then
            _productoElim = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Entrada_Simple(objKardex As clsKardex,
                              listaInventario As List(Of clsInventario), objADO As clsInventarioADO)
        For Each objAux In listaInventario
            For Each objMuestra In listaProductosAuxMovimiento
                If objAux.idProducto = objMuestra.ID Then 'Para que producto por producto me modifique inventario
                    objKardex.idProducto = objAux.idProducto
                    objKardex.precioRef = objMuestra.PRECIO
                    objADO.Entrada_Almacen_PA(objAux, objMuestra.CANTIDAD, objKardex)
                End If
            Next
        Next
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim objKardex As clsKardex
        Dim objADOInventario As New clsInventarioADO
        Dim listaInventarios As New List(Of clsInventario)
        Try
            If cmbMotivo.SelectedIndex > 0 And cmbTipoDocumento.SelectedIndex > 0 Then
                If dgvProductosAgregados.RowCount > 0 Then
                    For i = 0 To dgvProductosAgregados.Rows.Count - 1
                        Dim objInventario As clsInventario
                        objInventario = objADOInventario.buscarInventario(CInt(dgvProductosAgregados.Rows(i).Cells(0).Value.ToString), CInt(cmbSucursalRes.SelectedValue))
                        listaInventarios.Add(objInventario) 'Lista de los inventarios que se cambiaran
                    Next
                    'Kardex de Salida
                    objKardex = New clsKardex(0, dtpFecha.Value, "ENTRADA", cmbMotivo.Text, cmbSucursalRes.Text, 0, 0, CInt(cmbSucursalRes.SelectedValue), txtDocumentoRef.Text, cmbEmpleado.Text, "", 0)

                    Entrada_Simple(objKardex, listaInventarios, objADOInventario)

                    MsgBox("ENTRADA REGISTRADA", 64)
                    listaProductosAuxMovimiento.Clear()
                    Me.Close()
                Else
                    MsgBox("No se ha especificado ningun producto", 16)
                End If
            Else
                MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class