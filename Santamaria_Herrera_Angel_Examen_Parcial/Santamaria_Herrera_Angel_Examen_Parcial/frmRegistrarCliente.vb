Imports Libreria_Clases
Public Class frmRegistrarCliente
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim obj As clsCliente

        If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtCorreo.Text.Trim.Length > 0 And cmbPersona.SelectedIndex <> 0 Then
            If buscarCliente(txtDNI.Text) = -1 Then
                obj = New clsCliente(txtDNI.Text.Trim, txtNombres.Text.Trim, txtCorreo.Text.Trim, cmbPersona.Text)
                coleccionClientes.Add(obj)
                MsgBox("Cliente Registrado")
                limpiar()
                cargarDatos()
            Else
                MsgBox("DNI de Cliente ya Existe")
                limpiar()
            End If
        Else
            MsgBox("Debe Completar todos los Datos")
        End If
    End Sub

    Private Sub frmRegistrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cmbPersona.SelectedIndex = 0
    End Sub

    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionClientes.Count - 1
            lstDatos.Items.Add(coleccionClientes.Item(i).mostrar)
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtDNI.Clear()
        txtNombres.Clear()
        txtCorreo.Clear()
    End Sub

End Class