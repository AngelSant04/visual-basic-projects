Imports Capa_Datos
Imports Capa_Entidades
Public Class frmMantProducto
    Private IDPRODUCTO As Integer
    Private idAlmacen As Integer
    Private objAdoInventario As New clsInventarioADO
    Private obj As clsInventario
    Private Sub cargarCategorias()
        Dim objADO As New clsCategoriaProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            ComboCategoria.DataSource = dt
            ComboCategoria.DisplayMember = "descripcion"
            ComboCategoria.ValueMember = "idCategoria"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmMantProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCategorias()
        cmbEstado.SelectedIndex = 0
        txtRazSocial.Enabled = False
        rbtnJuridica.Enabled = False
        rbtnNatural.Enabled = False
        If IsNothing(productoGlobal) Then
            btnModificar.Enabled = False
            btnGuardar.Enabled = True
        Else
            Dim objAdo As New clsProveedorADO
            IDPRODUCTO = productoGlobal.idProducto
            btnModificar.Enabled = True
            btnGuardar.Enabled = False
            txtNombre.Text = productoGlobal.nombre
            ComboCategoria.SelectedValue = productoGlobal.idCategoria
            txtPrecio.Text = productoGlobal.precio.ToString
            txtCosto.Text = productoGlobal.costo.ToString
            cmbEstado.SelectedIndex = productoGlobal.estado
            txtidProveedor.Text = productoGlobal.idProveedor
            proveedorGlobal = objAdo.buscarProveedor(txtidProveedor.Text)
            txtRazSocial.Text = proveedorGlobal.nombre
            If proveedorGlobal.tipoDocumento = "P. Juridica" Then
                rbtnJuridica.Checked = True
                rbtnNatural.Checked = False
            Else
                rbtnNatural.Checked = True
                rbtnJuridica.Checked = False
            End If
            obj = objAdoInventario.buscarInventariox(IDPRODUCTO)
            idAlmacen = obj.idAlmacen
            txtMinimo.Text = obj.stockMinimo
            txtMaximo.Text = obj.stockMaximo
            inventarioGlobal = Nothing
            productoGlobal = Nothing
            proveedorGlobal = Nothing
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADO As New clsProductoADO
        Dim objADOInventario As New clsInventarioADO
        Dim obj As clsProducto
        Dim contador As Integer
        Dim objInventario As clsInventario
        Dim _aux As Integer
        Try
            If txtNombre.Text.Length > 0 And txtPrecio.Text.Length > 0 And txtCosto.Text.Length > 0 And cmbEstado.SelectedIndex > 0 And txtidProveedor.Text.Length > 0 And txtRazSocial.Text.Length > 0 Then
                If CDbl(txtCosto.Text) > CDbl(txtPrecio.Text) Then
                    MsgBox("COSTO NO DEBE SER MAYOR A PRECIO DE VENTA")
                Else
                    obj = New clsProducto(0, txtNombre.Text, cmbEstado.SelectedIndex, CDbl(txtPrecio.Text), CDbl(txtCosto.Text), CInt(ComboCategoria.SelectedValue), txtidProveedor.Text)
                    _aux = objADO.agregarProducto_PA(obj)
                    contador = objADOInventario.contarAlmacenes
                    For i = 1 To contador
                        objInventario = New clsInventario(_aux, i, CInt(txtMinimo.Text), CInt(txtMaximo.Text), 0)
                        objADOInventario.agregarInventario_PA(objInventario)
                    Next
                    MsgBox("PRODUCTO AGREGADO E INVENTARIO CREADO", 64)
                    Me.Close()
                End If
            Else
                MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim objAdo As New clsProveedorADO
        proveedorGlobal = objAdo.buscarProveedor(txtidProveedor.Text)
        If IsNothing(proveedorGlobal) Then
            Dim _valor As Integer
            _valor = MsgBox("PROVEEDOR NO REGISTRADO, ¿DESEA REGISTRAR?", 4)
            If _valor = 6 Then
                Dim ventana As New frmMantProveedor
                ventana.Show()
            Else
                txtRazSocial.Text = ""
            End If
        Else
            txtRazSocial.Text = proveedorGlobal.nombre
            If proveedorGlobal.tipoDocumento = "P. Juridica" Then
                rbtnJuridica.Checked = True
                rbtnNatural.Checked = False
            Else
                rbtnNatural.Checked = True
                rbtnJuridica.Checked = False
            End If
        End If
        proveedorGlobal = Nothing
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objADO As New clsProductoADO
        Dim objADOInventario As New clsInventarioADO
        Dim obj As clsProducto
        Dim objInventario As clsInventario
        Dim contador As Integer
        Try
            If txtNombre.Text.Length > 0 And txtPrecio.Text.Length > 0 And txtCosto.Text.Length > 0 And cmbEstado.SelectedIndex > 0 And txtidProveedor.Text.Length > 0 And txtRazSocial.Text.Length > 0 Then
                If CDbl(txtCosto.Text) > CDbl(txtPrecio.Text) Then
                    MsgBox("COSTO NO DEBE SER MAYOR A PRECIO DE VENTA")
                Else
                    obj = New clsProducto(IDPRODUCTO, txtNombre.Text, cmbEstado.SelectedIndex, CDbl(txtPrecio.Text), CDbl(txtCosto.Text), CInt(ComboCategoria.SelectedValue), txtidProveedor.Text)
                    objADO.modificarProducto_PA(obj)
                    contador = objADOInventario.contarAlmacenes
                    For i = 1 To contador
                        objInventario = New clsInventario(IDPRODUCTO, i, CInt(txtMinimo.Text), CInt(txtMaximo.Text), 0)
                        objADOInventario.modificarDatosInventario_PA(objInventario)
                    Next

                    MsgBox("PRODUCTO E INVENTARIO MODIFICADO", 64)
                    Me.Close()
                End If
            Else
                MsgBox("Falta Completar Campos Obligatorios", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class