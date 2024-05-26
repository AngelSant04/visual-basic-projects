Imports Libreria
Public Class WebRegistraEmpleado
    Inherits System.Web.UI.Page


    Dim lista As List(Of clsEmpleado)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Extraer de la sesion
        lista = CType(Session("listaE"), List(Of clsEmpleado))
        If lista Is Nothing Then
            lista = New List(Of clsEmpleado)
            'Guardar en la sesion
            Session("listaE") = lista
        End If
    End Sub

    Protected Sub btnRegistra_Click(sender As Object, e As EventArgs) Handles btnRegistra.Click
        Dim obj As clsEmpleado
        obj = New clsEmpleado(txtDni.Text, txtNombres.Text, cmbArea.SelectedValue)
        'Extraer la lista de la sesion y agregar el nuevo objeto Empleado
        lista = CType(Session("listaE"), List(Of clsEmpleado))
        lista.Add(obj)
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("principal.html")
    End Sub
End Class