Public Class clsActa
    Private _fecha As String
    Private _representanteComunidad As String
    Private _representanteMunicipalidad As String
    Private coleccionProductos As clsColeccionProductos

    Public Function mostrar() As String
        Return _fecha & " - " & _representanteComunidad & " - " & _representanteMunicipalidad & " - " & coleccionProductos.presentar()
    End Function

    Public Sub New(fecha As String, representante As String, municipalidad As String, coleccion As clsColeccionProductos)
        _fecha = fecha
        _representanteComunidad = representante
        _representanteMunicipalidad = municipalidad
        coleccionProductos = coleccion
    End Sub


End Class
