Imports Capa_Datos
Imports Capa_Entidades
Public Class frmAnadirProductoVenta
    Private _producto As Integer
    Private muestraGlobal As clsMuestraAuxiliarVenta

    Private Sub limpiar()
        txtCantidad.Clear()
        txtIDProducto.Clear()
        txtImporte.Clear()
        txtNombre.Clear()
        txtStock.Clear()
        txtPrecio.Text = 0
        txtNombre.Clear()
    End Sub

    Protected Sub cargarDatos()
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoProductoVenta(sucursalAux)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecialCarrito(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletraVenta(sucursalAux, texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecialCarrito_Nombre(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombreVenta(sucursalAux, texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        bandGlobal = 0
        Me.Close()
    End Sub

    Private Sub frmAnadirProductoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        txtIDProducto.Text = dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString
        _producto = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        txtNombre.Text = dgvDatos.SelectedRows().Item(0).Cells(1).Value.ToString
        txtPrecio.Text = dgvDatos.SelectedRows().Item(0).Cells(2).Value.ToString
        txtStock.Text = dgvDatos.SelectedRows().Item(0).Cells(3).Value.ToString
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub



    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim precio, cantidad, importe As Double
        If txtCantidad.TextLength > 0 Then
            precio = CDbl(txtPrecio.Text)
            cantidad = CDbl(txtCantidad.Text)
            importe = precio * cantidad
            txtImporte.Text = importe.ToString
        Else
            If txtCantidad.Text = "" Then
                txtImporte.Text = ""
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADO As New clsInventarioADO
        Dim objADOProducto As New clsProductoADO
        Dim band As Integer = 0
        ''inventarioGlobal = objADO.buscarInventario(_producto, _almacen)
        productoGlobal = objADOProducto.buscarProducto(_producto)
        If productoGlobal Is Nothing Then
            MsgBox("SELECCIONE UN PRODUCTO")
        Else
            If txtCantidad.TextLength > 0 And txtImporte.TextLength > 0 Then
                If CInt(txtCantidad.Text) > CInt(txtStock.Text) Then
                    MsgBox("CANTIDAD EXCEDE AL STOCK ACTUAL")
                Else
                    If CInt(txtCantidad.Text) <= 0 Then
                            MsgBox("CANTIDAD ERRONEA", 16)
                        Else
                            muestraGlobal = New clsMuestraAuxiliarVenta(_producto, productoGlobal.nombre, CInt(txtCantidad.Text), productoGlobal.costo, CDbl(txtImporte.Text))
                            For i = 0 To listaProductosAuxVenta.Count - 1
                                If listaProductosAuxVenta.Item(i).ID = muestraGlobal.ID Then
                                    band = 1
                                    Exit For
                                End If
                            Next
                            If band = 0 Then
                                listaProductosAuxVenta.Add(muestraGlobal)
                                productoGlobal = Nothing
                                Me.Close()
                            Else
                                MsgBox("Producto Ya Se Encuentra Agregado")
                            End If
                        End If

                    End If
            Else
                MsgBox("CAMPOS INCOMPLETOS", 64)
            End If
        End If
    End Sub
    Private Sub txtProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyUp
        Dim valor As String
        Dim band As Integer = 0
        valor = txtProducto.Text
        If IsNumeric(valor) Then
            band = 1
        End If
        If band = 1 Then
            cargarDatosEspecialCarrito(txtProducto.Text)
        Else
            cargarDatosEspecialCarrito_Nombre(txtProducto.Text)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargarDatos()
    End Sub

End Class