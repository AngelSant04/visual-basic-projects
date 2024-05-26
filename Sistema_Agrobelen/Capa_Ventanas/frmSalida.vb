Imports Capa_Datos
Imports Capa_Entidades
Public Class dgvDatos2
    Dim sucurAux As Integer = 1
    Dim muestra As clsMuestraAuxMovimiento
    Dim _producto As Integer
    Dim _producto2 As Integer = -1
    Private Sub limpiar()
        txtID.Clear()
        txtNombre.Clear()
        txtPrecioRef.Clear()
        txtStock.Clear()
        txtCantidad.Clear()
        txtProductoBuscar.Clear()
    End Sub
    Protected Sub cargarDatosEspecial(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletraVenta(cmbSucur.SelectedIndex + 1, texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecialNombre(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombreVenta(cmbSucur.SelectedIndex + 1, texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub contarkardex() 'Genera Nuevo Numero de Salida
        Dim objADO As New clsKardexADO
        Dim contador As Integer
        contador = objADO.contarKardex("SALIDA")
        txtSalida.Text = contador + 1
    End Sub
    Private Sub cargarAlmacenRef()
        Dim objADO As New clsAlmacenADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoCombo
            cmbSucur.DataSource = dt
            cmbSucur.DisplayMember = "sucursal"
            cmbSucur.ValueMember = "idAlmacen"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub cargarAlmacenRes()   'Carga los almacenes
        Dim objADO As New clsAlmacenADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoCombo  'Metodo en mi capa datos
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
    Protected Sub cargarDatos()   'Carga el DGV
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoProductoVenta(sucurAux)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub cargarEmpleadosActivos()  'Carga el combo de empleados
        Dim objADO As New clsEmpleadoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoActivo
            cmbEmpleado.DataSource = dt
            cmbEmpleado.DisplayMember = "NOMBRES COMPLETOS" 'Muestra en el combo
            cmbEmpleado.ValueMember = "ID" 'Guardar ID
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAlmacenRes()
        cargarAlmacenRef()
        cmbTipoDocumento.SelectedIndex = 0
        cmbMotivo.SelectedIndex = 0
        cargarEmpleadosActivos()
        cargarDatos()
        contarkardex()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click 'Agregar
        Dim objADO As New clsInventarioADO
        Dim objADOProducto As New clsProductoADO
        Dim band As Integer = 0
        productoGlobal = objADOProducto.buscarProducto(_producto)
        If txtCantidad.TextLength > 0 And txtStock.TextLength > 0 Then
            If CInt(txtCantidad.Text) > CInt(txtStock.Text) Then
                MsgBox("CANTIDAD EXCEDE AL STOCK ACTUAL")
            Else
                If productoGlobal Is Nothing Then
                    MsgBox("SELECCIONE UN PRODUCTO")
                Else
                    If CInt(txtCantidad.Text) <= 0 Then
                        MsgBox("CANTIDAD ERRONEA", 16)
                    Else
                        'Clase de Referencia -> Solo es muestra
                        muestra = New clsMuestraAuxMovimiento(_producto, productoGlobal.nombre, CInt(txtCantidad.Text), CDbl(txtPrecioRef.Text))
                        'Para que no agregue otra vez el mismo producto
                        For i = 0 To listaProductosAuxMovimiento.Count - 1
                            If listaProductosAuxMovimiento.Item(i).ID = muestra.ID Then
                                band = 1
                                Exit For
                            End If
                        Next
                        If band = 0 Then
                            listaProductosAuxMovimiento.Add(muestra)
                            dgvProductosAgregados.DataSource = Nothing 'Libero De Datos
                            dgvProductosAgregados.DataSource = listaProductosAuxMovimiento
                            If listaProductosAuxMovimiento.Count = 1 Then
                                cmbSucursalRes.Enabled = False
                            End If
                            productoGlobal = Nothing 'Anularla, Vaciarla
                            limpiar()
                        Else
                            MsgBox("Producto Ya Se Encuentra Agregado")
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("CAMPOS INCOMPLETOS", 64)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If dgvProductosAgregados.RowCount >= 1 Then
            If _producto2 >= 1 Then
                For i = 0 To listaProductosAuxMovimiento.Count - 1
                    If listaProductosAuxMovimiento.Item(i).ID = _producto2 Then
                        listaProductosAuxMovimiento.Remove(listaProductosAuxMovimiento.Item(i))
                        dgvProductosAgregados.DataSource = Nothing
                        dgvProductosAgregados.DataSource = listaProductosAuxMovimiento
                        _producto2 = 0
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

    Private Sub dgvDatosAgregados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductosAgregados.CellClick
        If dgvProductosAgregados.Rows.Count > 0 Then
            _producto2 = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        End If
    End Sub
    'Key del busqueda por Nombre
    Private Sub TextBox8_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProductoBuscar.KeyUp
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        cargarDatos()
        limpiar()
    End Sub
    Private Sub Salida_Simple(objKardex As clsKardex,
                              listaInventario As List(Of clsInventario))
        Dim objADOInventario As New clsInventarioADO
        For Each objAux In listaInventario
            For Each objMuestra In listaProductosAuxMovimiento
                If objAux.idProducto = objMuestra.ID Then 'Para que producto por producto me modifique inventario
                    objKardex.idProducto = objAux.idProducto
                    objKardex.precioRef = objMuestra.PRECIO
                    objADOInventario.Salida_Almacen_PA(objAux, objMuestra.CANTIDAD, objKardex)
                End If
            Next
        Next
    End Sub
    Private Sub Salida_Entrada(objKardex1 As clsKardex, objKardex2 As clsKardex,
                              listaInventario1 As List(Of clsInventario), listaInventario2 As List(Of clsInventario))
        Salida_Simple(objKardex1, listaInventario1)
        Dim objADOInventario As New clsInventarioADO
        For Each objAux In listaInventario2
            For Each objMuestra In listaProductosAuxMovimiento
                If objAux.idProducto = objMuestra.ID Then 'Para que producto por producto me modifique inventario
                    objKardex2.idProducto = objAux.idProducto
                    objKardex2.precioRef = objMuestra.PRECIO
                    objADOInventario.Entrada_Almacen_PA(objAux, objMuestra.CANTIDAD, objKardex2)
                End If
            Next
        Next
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim objKardex As clsKardex
        Dim objKardex2 As clsKardex
        Dim objADOInventario As New clsInventarioADO
        Dim listaInventarios As New List(Of clsInventario)
        Dim listaInventarios2 As New List(Of clsInventario)
        Try
            If cmbMotivo.SelectedIndex > 0 Then
                If dgvProductosAgregados.RowCount > 0 Then
                    For i = 0 To dgvProductosAgregados.Rows.Count - 1
                        'Buscar el inventario donde cambiara el stock
                        Dim objInventario As clsInventario
                        objInventario = objADOInventario.buscarInventario(CInt(dgvProductosAgregados.Rows(i).Cells(0).Value.ToString), cmbSucursalRes.SelectedIndex + 1)
                        listaInventarios.Add(objInventario) 'Lista de los inventarios que se cambiaran
                    Next
                    'Kardex de Salida
                    objKardex = New clsKardex(0, dtpFecha.Value, "SALIDA", cmbMotivo.Text, cmbSucursalRes.Text, 0, 0, cmbSucursalRes.SelectedIndex + 1, txtDocumentoRef.Text, cmbEmpleado.Text, "", 0)
                    If cmbMotivo.SelectedIndex = 1 Then
                        objKardex.destino = cmbSucur.Text
                        objKardex2 = New clsKardex(0, dtpFecha.Value, "ENTRADA", cmbMotivo.Text, cmbSucursalRes.Text, 0, 0, cmbSucur.SelectedIndex + 1, txtDocumentoRef.Text, cmbEmpleado.Text, "", 0)
                        For i = 0 To dgvProductosAgregados.Rows.Count - 1
                            'Guardar los inventarios que voy a modificar
                            Dim objInventario2 As clsInventario
                            objInventario2 = objADOInventario.buscarInventario(CInt(dgvProductosAgregados.Rows(i).Cells(0).Value.ToString), cmbSucur.SelectedIndex + 1)
                            listaInventarios2.Add(objInventario2)
                        Next
                        Salida_Entrada(objKardex, objKardex2, listaInventarios, listaInventarios2)
                    Else
                        Salida_Simple(objKardex, listaInventarios)
                    End If
                    MsgBox("SALIDA REGISTRADA", 64)
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
End Class