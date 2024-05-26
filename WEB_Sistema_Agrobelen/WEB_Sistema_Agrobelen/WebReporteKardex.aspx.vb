Imports Capa_Datos
Imports Capa_Entidades
Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim idAlmacen As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarDatos()
        cargarAlmacenes()
    End Sub
    Private Sub cargarAlmacenes()
        Dim objADO As New clsAlmacenADO
        Dim dt As DataTable
        Try
            dt = objADO.listadoCombo
            cmbAlmacen.DataSource = dt
            cmbAlmacen.DataBind()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub cargarDatosXAlmacen()
        Dim objAdo As New clsKardexADO
        Try
            gvDatos.DataSource = objAdo.listadoXAlmacen()
            gvDatos.DataBind()
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub
    Private Sub cargarDatos()
        Dim objAdo As New clsKardexADO
        Try
            gvDatos.DataSource = objAdo.listado()
            gvDatos.DataBind()
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub
End Class