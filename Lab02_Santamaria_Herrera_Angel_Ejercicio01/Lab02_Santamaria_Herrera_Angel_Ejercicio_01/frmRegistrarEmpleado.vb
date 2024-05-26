Imports Libreria_Clases
Public Class frmRegistrarEmpleado
    Private pos As Integer

    Private Sub limpiar()
        txtDNI.Clear()
        txtNombres.Clear()
        txtEdad.Clear()
        txtDireccion.Clear()
        txtCargo.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim obj As clsEmpleado
        Dim objArea As clsAreaAsignada

        If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtEdad.Text.Trim.Length > 0 And txtDireccion.Text.Trim.Length > 0 And txtCargo.Text.Trim.Length > 0 And txtDescripcion.Text.Trim.Length > 0 Then
            If coleccionAreas.getArea(pos).getCantidad <> 0 Then
                If buscarEmpleado(txtDNI.Text) = -1 Then
                    objArea = New clsAreaAsignada(txtCargo.Text.Trim, txtDescripcion.Text.Trim)
                    obj = New clsEmpleado(txtDNI.Text.Trim, txtNombres.Text.Trim, CInt(txtEdad.Text.Trim), txtDireccion.Text.Trim, objArea)
                    coleccionEmpleado.agregar(obj)
                    'Bajar cupos en Area Seleccionada
                    coleccionAreas.getArea(pos).reducirCantidad()
                    MsgBox("Empleado Registrado en Area Asignada")
                    limpiar()
                    cargarDatos()
                Else
                    MsgBox("DNI ya existente")
                    limpiar()
                End If
            Else
                MsgBox("No existe cupos en esta area")
                limpiar()
            End If
        Else
            MsgBox("Debe Completar todos los Datos")
        End If
    End Sub

    Private Sub frmRegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Public Sub cargarDatos()
        lstDatos.Items.Clear()
        For i = 0 To coleccionAreas.getTotal - 1
            lstDatos.Items.Add(coleccionAreas.getArea(i).mostrar)
        Next
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub lstDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDatos.SelectedIndexChanged
        'Cortar Cadenas
        Dim datos() As String = Split(lstDatos.SelectedItem.ToString, "-")
        txtCargo.Text = datos(0).Trim
        pos = lstDatos.SelectedIndex
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class