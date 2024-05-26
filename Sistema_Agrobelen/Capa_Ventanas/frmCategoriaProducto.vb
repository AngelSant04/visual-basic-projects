Imports Capa_Datos
Imports Capa_Entidades
Public Class frmCategoriaProducto
    Private idCategoria As Integer
    Private Sub frmCategoriaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub
    Protected Sub cargarDatos()
        Dim objADO As New clsCategoriaProductoADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoCompleto
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objADO As New clsCategoriaProductoADO
        Dim obj As clsCategoriaProducto
        Try
            If txtDescripcion.Text.Trim.Length > 0 Then
                obj = New clsCategoriaProducto(0, txtDescripcion.Text)
                objADO.agregarCategoriaProducto_PA(obj)
                MsgBox("Categoria de Producto Agregado", 64)
                cargarDatos()
                Limpiar()
            Else
                MsgBox("Falta Completar Campos", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub Limpiar()
        txtDescripcion.Text = ""
        btnAgregar.Enabled = True
        btnEditar.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim obj As clsCategoriaProducto
        Dim objADO As New clsCategoriaProductoADO

        'agregar a la base de datos este objeto '
        Try
            If txtDescripcion.Text.Trim.Length > 0 Then
                obj = New clsCategoriaProducto(idCategoria, txtDescripcion.Text)
                objADO.modificarCategoriaProducto_PA(obj)
                MsgBox("Categoria Modificada", 64)
                cargarDatos()
                Limpiar()
            Else
                MsgBox("Falta Completar Campos", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        idCategoria = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value)
        txtDescripcion.Text = dgvDatos.SelectedRows().Item(0).Cells(1).Value
        btnEditar.Enabled = True
        btnAgregar.Enabled = False
    End Sub
End Class