Public Class clsProducto
    Private _codigo As String
    Private _descripcion As String
    Private _tipoProducto As Integer
    Private _tipoPresentacion As String
    Private _Cantidad As Integer
    Private _adquisicion As String

    Public Sub New(codigo As String, descripcion As String, tProducto As Integer, tPresentacion As String,
                   cantidad As Integer, adquisicion As String)
        _codigo = codigo
        _descripcion = descripcion
        _tipoProducto = tProducto
        _tipoPresentacion = tPresentacion
        _Cantidad = cantidad
        _adquisicion = adquisicion
    End Sub

    Public Function mostrar() As String
        Return _codigo & " - " & _descripcion & " - " & _tipoProducto & " - " & _Cantidad
    End Function

    Public Sub setCantidad(cantidad As Integer)
        _Cantidad = cantidad
    End Sub

    Public Function getCantidad()
        Return _Cantidad
    End Function


    Public Property GSCodigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property GSCantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

End Class
