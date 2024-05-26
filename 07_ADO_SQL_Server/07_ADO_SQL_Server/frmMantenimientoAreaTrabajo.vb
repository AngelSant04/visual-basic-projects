Imports CapaDatos
Imports CapaEntidades

Public Class frmMantenimientoAreaTrabajo
    Private idArea As Integer
    Private Sub frmMantenimientoAreaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        Dim objAdo As New clsAreaTrabajoADO
        Dim dt As DataTable

        Try
            dt = objAdo.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub limpiar()
        txtDescripcion.Text = ""
        txtNombreJefe.Text = ""
        idArea = 0
        btnModificar.Enabled = False
        btnRegistrar.Enabled = True
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objADO As New clsAreaTrabajoADO
        Dim obj As clsAreaTrabajo

        Try
            'Validar el ingreso de datos
            If txtDescripcion.Text.Trim.Length > 0 And txtNombreJefe.Text.Trim.Length > 0 Then
                obj = New clsAreaTrabajo(0, txtDescripcion.Text, txtNombreJefe.Text)
                'objADO.agregar(obj)
                objADO.agregar_PA(obj)
                MsgBox("Area Agregada")
                limpiar()
                cargarDatos()
            Else
                MsgBox("Debe llenar todos los campos")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        idArea = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        txtDescripcion.Text = dgvDatos.SelectedRows().Item(0).Cells(1).Value.ToString
        txtNombreJefe.Text = dgvDatos.SelectedRows().Item(0).Cells(2).Value.ToString
        btnRegistrar.Enabled = False
        btnModificar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objADO As New clsAreaTrabajoADO
        Dim obj As clsAreaTrabajo

        Try
            'Validar el ingreso de datos
            If txtDescripcion.Text.Trim.Length > 0 And txtNombreJefe.Text.Trim.Length > 0 Then
                obj = New clsAreaTrabajo(idArea, txtDescripcion.Text, txtNombreJefe.Text)
                objADO.modificar(obj)
                MsgBox("Area Modificada")
                limpiar()
                cargarDatos()
            Else
                MsgBox("Debe llenar todos los campos")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub
End Class