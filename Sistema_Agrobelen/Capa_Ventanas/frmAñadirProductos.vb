Imports Capa_Entidades
Imports Capa_Datos
Public Class frmAñadirProductos
    Private _producto As Integer
    Private _almacen As Integer
    Private muestraGlobal As clsMuestraAuxliliar
    Dim objInventarioADO As New clsInventarioADO

    Private Sub limpiar()
        txtIDProducto.Clear()
        txtNombre.Clear()
        txtCosto.Text = 0
        txtCantidad.Text = 0
        txtImporte.Clear()
        txtStockMin.Clear()
        txtStockMax.Clear()
    End Sub

    Protected Sub cargarDatos(sucursal As Integer)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXAlmacen(sucursal)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmAñadirProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos(sucursalAux)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        bandGlobal = 0
        Me.Close()
    End Sub
    Protected Sub cargarDatosEspecial(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXletra(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Protected Sub cargarDatosEspecial_Nombre(texto As String)
        Dim objADO As New clsProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoXnombre(texto)
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyUp
        Dim valor As String
        Dim band As Integer = 0
        valor = txtProducto.Text
        If IsNumeric(valor) Then
            band = 1
        End If
        If band = 1 Then
            cargarDatosEspecial(txtProducto.Text)
        Else
            cargarDatosEspecial_Nombre(txtProducto.Text)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objADO As New clsInventarioADO
        Dim objADOProducto As New clsProductoADO
        Dim band As Integer = 0
        inventarioGlobal = objADO.buscarInventario(_producto, _almacen)
        productoGlobal = objADOProducto.buscarProducto(_producto)
        If productoGlobal Is Nothing Then
            MsgBox("SELECCIONE UN PRODUCTO")
        Else
            If CInt(txtCantidad.Text) <= 0 Or CDbl(txtCosto.Text) <= 0 Then
                MsgBox("CANTIDAD O COSTO ERRONEO", 16)
            Else
                If txtIDProducto.TextLength > 0 And txtNombre.TextLength > 0 And CDbl(txtCosto.Text) <> 0 And
                    CInt(txtCantidad.Text) <> 0 And CDbl(txtImporte.Text) <> 0 And txtStockMin.TextLength > 0 And txtStockMax.TextLength > 0 Then
                    If (inventarioGlobal.stockReal + CInt(txtCantidad.Text)) < CInt(txtStockMin.Text) Then
                        Dim _valor As Integer
                        _valor = MsgBox("Si compra esta cantidad ingresada, el stock seria menor que el stock minimo Permitido ¿Desea Continuar? ", 4)
                        If _valor = 6 Then
                            muestraGlobal = New clsMuestraAuxliliar(_producto, _almacen, productoGlobal.nombre, CInt(txtCantidad.Text), CDbl(txtCosto.Text), CDbl(txtImporte.Text))
                            For i = 0 To listaProductosAux.Count - 1
                                If listaProductosAux.Item(i).ID = muestraGlobal.ID Then
                                    band = 1
                                    Exit For
                                End If
                            Next
                            If band = 0 Then
                                listaProductosAux.Add(muestraGlobal)
                                productoGlobal = Nothing
                                Me.Close()
                            Else
                                MsgBox("Producto Ya Se Encuentra Agregado")
                            End If
                        Else
                            Me.Close()
                        End If
                    Else
                        If (inventarioGlobal.stockReal + CInt(txtCantidad.Text)) > CInt(txtStockMax.Text) Then
                            Dim _valor As Integer
                            _valor = MsgBox("Si compra esta cantidad ingresada, el stock seria mayor que el stock maximo Permitido ¿Desea Continuar? ", 4)
                            If _valor = 6 Then
                                muestraGlobal = New clsMuestraAuxliliar(_producto, _almacen, productoGlobal.nombre, CInt(txtCantidad.Text), CDbl(txtCosto.Text), CDbl(txtImporte.Text))
                                For i = 0 To listaProductosAux.Count - 1
                                    If listaProductosAux.Item(i).ID = muestraGlobal.ID Then
                                        band = 1
                                        Exit For
                                    End If
                                Next
                                If band = 0 Then
                                    listaProductosAux.Add(muestraGlobal)
                                    productoGlobal = Nothing
                                    Me.Close()
                                Else
                                    MsgBox("Producto Ya Se Encuentra Agregado")
                                End If
                            Else
                                Me.Close()
                            End If
                        Else
                            muestraGlobal = New clsMuestraAuxliliar(_producto, _almacen, productoGlobal.nombre, CInt(txtCantidad.Text), CDbl(txtCosto.Text), CDbl(txtImporte.Text))
                            For i = 0 To listaProductosAux.Count - 1
                                If listaProductosAux.Item(i).ID = muestraGlobal.ID Then
                                    band = 1
                                    Exit For
                                End If
                            Next
                            If band = 0 Then
                                listaProductosAux.Add(muestraGlobal)
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
        End If
    End Sub
    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Dim obj As clsInventario
        _producto = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value)
        _almacen = CInt(dgvDatos.SelectedRows().Item(0).Cells(1).Value)
        obj = objInventarioADO.buscarInventario(_producto, _almacen)
        txtIDProducto.Text = obj.idProducto.ToString
        txtNombre.Text = dgvDatos.SelectedRows().Item(0).Cells(3).Value.ToString
        txtStockMin.Text = obj.stockMinimo.ToString
        txtStockMax.Text = obj.stockMaximo.ToString
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub txtCosto_TextChanged(sender As Object, e As EventArgs) Handles txtCosto.TextChanged
        Dim costo, cantidad, importe As Double
        If txtCosto.TextLength = 0 Then
            If txtCantidad.TextLength = 0 Then
                costo = 0
                cantidad = 0
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            Else
                costo = 0
                cantidad = CDbl(txtCantidad.Text)
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            End If
        Else
            If txtCantidad.TextLength > 0 Then
                costo = CDbl(txtCosto.Text)
                cantidad = CDbl(txtCantidad.Text)
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            Else
                costo = CDbl(txtCosto.Text)
                cantidad = 0
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            End If
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim costo, cantidad, importe As Double
        If txtCantidad.TextLength = 0 Then
            If txtCosto.TextLength = 0 Then
                costo = 0
                cantidad = 0
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            Else
                costo = CDbl(txtCosto.Text)
                cantidad = 0
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            End If
        Else
            If txtCosto.TextLength > 0 Then
                costo = CDbl(txtCosto.Text)
                cantidad = CDbl(txtCantidad.Text)
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            Else
                costo = 0
                cantidad = CDbl(txtCantidad.Text)
                importe = costo * cantidad
                txtImporte.Text = importe.ToString
            End If
        End If
    End Sub
    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Class