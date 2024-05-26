Imports CapaDatos
Imports CapaEntidades
Public Class frmMantenimientoProfesion
    Private idProfesion As Integer
    Private Sub frmMantenimientoProfesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        Dim objAdo As New clsProfesionADO
        Dim dt As DataTable

        Try
            dt = objAdo.listado
            dgvDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objADO As New clsProfesionADO
        Dim obj As clsProfesion

        Try
            'Validar el ingreso de datos
            obj = New clsProfesion(0, txtDescripcion.Text)
            'objADO.agregar(obj)
            objADO.agregar_PA(obj)
            MsgBox("Profesion Agregada")
            limpiar()
            cargarDatos()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    'End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objADO As New clsProfesionADO
        Dim obj As clsProfesion

        Try
            'Validar el ingreso de datos
            obj = New clsProfesion(idProfesion, txtDescripcion.Text)
            objADO.modificar(obj)
            MsgBox("Profesion Modificada")
            limpiar()
            cargarDatos()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub limpiar()
        txtDescripcion.Text = ""
        idProfesion = 0
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        idProfesion = CInt(dgvDatos.SelectedRows().Item(0).Cells(0).Value.ToString)
        txtDescripcion.Text = dgvDatos.SelectedRows().Item(0).Cells(1).Value.ToString
    End Sub
End Class