Public Class clsComprobante
    Public Sub New(numComprobante As Integer, tipoComprobante As String, idVenta As Integer, numTalonario As Integer)
        Me.numComprobante = numComprobante
        Me.tipoComprobante = tipoComprobante
        Me.idVenta = idVenta
        Me.numTalonario = numTalonario
    End Sub

    Property numComprobante As Integer
    Property tipoComprobante As String

    Property idVenta As Integer
    Property numTalonario As Integer

End Class
