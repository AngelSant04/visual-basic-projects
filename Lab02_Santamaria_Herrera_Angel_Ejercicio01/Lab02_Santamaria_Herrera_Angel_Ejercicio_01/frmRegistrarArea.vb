Imports Libreria_Clases
Public Class frmRegistrarArea
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim obj As clsAreas

        If txtArea.Text.Trim.Length > 0 And txtJefe.Text.Trim.Length > 0 And txtEmpleados.Text.Trim.Length > 0 Then
            If buscarArea(txtArea.Text) = -1 Then
                obj = New clsAreas(txtJefe.Text.Trim, txtArea.Text.Trim, CInt(txtEmpleados.Text))
                coleccionAreas.agregar(obj)
                MsgBox("Area de Trabajo Agregada")
                limpiar()
                cargarDatos()
            Else
                MsgBox("Nombre de Area ya Registrada")
                limpiar()
            End If
        Else
            MsgBox("Debe Completar todos los Datos")
        End If
    End Sub

    Private Sub limpiar()
        txtJefe.Clear()
        txtArea.Text = ""
        txtEmpleados.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmRegistrarArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionAreas.getTotal - 1
            lstDatos.Items.Add(coleccionAreas.getArea(i).mostrar)
        Next
    End Sub
End Class