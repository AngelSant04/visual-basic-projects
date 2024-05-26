Imports Libreria
Public Class WebListado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lista As List(Of clsEmpleado)

        lista = CType(Session("listaE"), List(Of clsEmpleado))
        gvDatos.DataSource = lista
        gvDatos.DataBind()
    End Sub

    Protected Sub btnRetornar_Click(sender As Object, e As EventArgs) Handles btnRetornar.Click
        Response.Redirect("principal.html")
    End Sub
End Class