Imports Libreria_Clases
Public Class frmModificarArea
    Private _cantAux As Integer
    Private posAntigua As Integer
    Private posNueva As Integer
    Private _posEmpleado As Integer

    Private Sub frmModificarArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To coleccionEmpleado.getTotal - 1
            lstDatos.Items.Add(coleccionEmpleado.getEmpleado(i).mostrar)
        Next

        For i = 0 To coleccionAreas.getTotal - 1
            lstAreas.Items.Add(coleccionAreas.getArea(i).mostrar)
        Next
    End Sub

    Private Sub lstDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDatos.SelectedIndexChanged
        Dim datos() As String = Split(lstDatos.SelectedItem.ToString, "-")
        txtDNIa.Text = datos(0).Trim
        txtNombresa.Text = datos(1).Trim
        txtEdada.Text = datos(2).Trim
        txtDirecciona.Text = datos(3).Trim
        txtAreaa.Text = datos(4).Trim
        txtDescripciona.Text = datos(5).Trim
        '========================
        'DATOS ACTUALES
        txtDNI.Text = datos(0).Trim
        txtNombres.Text = datos(1).Trim
        txtEdad.Text = datos(2).Trim
        txtDireccion.Text = datos(3).Trim
        txtDescripcion.Text = datos(5).Trim

        For i = 0 To coleccionAreas.getTotal - 1
            If txtAreaa.Text = coleccionAreas.getArea(i).getNombre Then
                posAntigua = i
            End If
        Next

        txtDescripcion.Enabled = True
        _posEmpleado = lstDatos.SelectedIndex

    End Sub

    Private Sub lstAreas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAreas.SelectedIndexChanged
        Dim datos() As String = Split(lstAreas.SelectedItem.ToString, "-")
        txtArea.Text = datos(0).Trim
        _cantAux = CInt(datos(2).Trim)

        posNueva = lstAreas.SelectedIndex
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim obj As clsEmpleado
        Dim objArea As clsAreaAsignada

        If txtDNI.Text.Trim.Length > 0 And txtNombres.Text.Trim.Length > 0 And txtEdad.Text.Trim.Length > 0 And txtDireccion.Text.Trim.Length > 0 And txtArea.Text.Trim.Length > 0 Then
            If _cantAux <> 0 Then
                objArea = New clsAreaAsignada(txtArea.Text.Trim, txtDescripcion.Text.Trim)
                obj = New clsEmpleado(txtDNI.Text.Trim, txtNombres.Text.Trim, CInt(txtEdad.Text.Trim), txtDireccion.Text.Trim, objArea)
                'coleccionEmpleado.agregar(obj)
                coleccionEmpleado.modificarEmpleado(_posEmpleado, obj)
                'Bajar cupos en Area Seleccionada
                coleccionAreas.getArea(posAntigua).AumentarCantidad()
                coleccionAreas.getArea(posNueva).reducirCantidad()
                MsgBox("Empleado Modificado")
                limpiar()
                cargarDatos()
            Else
                MsgBox("No existe cupos en esta area")
                limpiar()
            End If
        Else
            MsgBox("Debe Completar todos los Datos")
        End If
    End Sub

    Private Sub limpiar()
        txtDNIa.Clear()
        txtNombresa.Clear()
        txtEdada.Clear()
        txtDirecciona.Clear()
        txtAreaa.Clear()
        txtDescripciona.Clear()
        txtDNI.Clear()
        txtNombres.Clear()
        txtEdad.Clear()
        txtDireccion.Clear()
        txtArea.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub cargarDatos()
        lstDatos.Items.Clear()
        lstAreas.Items.Clear()
        For i = 0 To coleccionAreas.getTotal - 1
            lstAreas.Items.Add(coleccionAreas.getArea(i).mostrar)
        Next
        For i = 0 To coleccionEmpleado.getTotal - 1
            lstDatos.Items.Add(coleccionEmpleado.getEmpleado(i).mostrar)
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class