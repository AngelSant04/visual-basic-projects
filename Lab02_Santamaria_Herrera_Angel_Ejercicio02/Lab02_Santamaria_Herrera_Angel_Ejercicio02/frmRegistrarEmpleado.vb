Imports Libreria_Clases
Public Class frmRegistrarEmpleado
    Private Sub limpiar()
        txtDNI.Clear()
        txtNombres.Clear()
        txtDistrito.Clear()
        txtTelefono.Clear()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim obj As clsEmpleado

        If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtDistrito.Text.Trim.Length > 0 And txtTelefono.Text.Trim.Length > 0 Then
            If buscarEmpleado(txtDNI.Text) = -1 Then
                obj = New clsEmpleado(txtDNI.Text.Trim, txtNombres.Text.Trim, txtDistrito.Text.Trim, txtTelefono.Text.Trim)
                coleccionEmpleados.agregar(obj)
                MsgBox("Empleado Registrado")
                limpiar()
                cargarDatos()
            Else
                MsgBox("DNI de Empleado ya Existe")
                limpiar()
            End If
        Else
            MsgBox("Debe Completar todos los Datos")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub frmRegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionEmpleados.getTotal - 1
            lstDatos.Items.Add(coleccionEmpleados.getEmpleado(i).mostrar)
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class