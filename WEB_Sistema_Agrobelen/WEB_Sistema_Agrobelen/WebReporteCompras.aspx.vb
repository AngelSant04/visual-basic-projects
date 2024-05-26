Imports Capa_Datos
Imports Capa_Entidades
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarDatos()
    End Sub
    Private Sub cargarDatos()
        Dim objAdo As New clsCompraADO
        Try
            gvDatos.DataSource = objAdo.listado
            gvDatos.DataBind()
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub
End Class