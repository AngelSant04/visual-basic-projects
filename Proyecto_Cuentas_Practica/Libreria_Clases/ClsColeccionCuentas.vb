Public Class ClsColeccionCuentas
    'Atributos
    Private _datos() As clsCuenta
    Private _total As Integer

    'Como es una lista dinamica que no tiene un numero definido de cuentas, por ende no
    'necesita constructor
    'Clasicos Agregar y Presentar
    Public Sub agregar(obj As clsCuenta)
        ReDim Preserve _datos(_total)            'Actualizaba el vector
        _datos(_total) = obj
        _total = _total + 1
    End Sub

    Public Function presentar() As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            contenido = contenido & _datos(i).mostrar & vbCrLf       'Mostrar = metodo en clase cuenta
        Next
        Return contenido
    End Function

    Public Function getTotal() As Integer
        Return _total
    End Function

End Class
