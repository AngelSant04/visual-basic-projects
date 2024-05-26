Imports Capa_Datos
Imports Capa_Entidades

Public Class frmAlmacen
    Private idAlmacen As Integer
    Protected Sub cargarDatos()
        Dim objADO As New clsAlmacenADO
        Dim dt As DataTable
        Try
            dt = objADO.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Limpiar()
        txtDescripcion.Text = ""
        txtSucursal.Text = ""
        btnAgregar.Enabled = True
        btnEditar.Enabled = False
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'crear objeto almacen '
        Dim obj As clsAlmacen
        Dim objADO As New clsAlmacenADO

        'agregar a la base de datos este objeto '
        Try
            If txtSucursal.Text.Trim.Length > 0 And txtDescripcion.Text.Trim.Length > 0 Then
                obj = New clsAlmacen(0, txtSucursal.Text, txtDescripcion.Text)
                objADO.agregarAlmacen_PA(obj)
                MsgBox("Almacen Agregado", 64)
                cargarDatos()
                Limpiar()
            Else
                MsgBox("Falta Completar Campos", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        idAlmacen = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value)
        txtSucursal.Text = dgvDatos.SelectedRows().Item(0).Cells(1).Value
        txtDescripcion.Text = dgvDatos.SelectedRows().Item(0).Cells(2).Value
        btnEditar.Enabled = True
        btnAgregar.Enabled = False
    End Sub

    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim obj As clsAlmacen
        Dim objADO As New clsAlmacenADO

        'agregar a la base de datos este objeto '
        Try
            If txtSucursal.Text.Trim.Length > 0 And txtDescripcion.Text.Trim.Length > 0 Then
                obj = New clsAlmacen(idAlmacen, txtSucursal.Text, txtDescripcion.Text)
                objADO.modificarAlmacen_PA(obj)
                MsgBox("Almacen Modificado", 64)
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


End Class