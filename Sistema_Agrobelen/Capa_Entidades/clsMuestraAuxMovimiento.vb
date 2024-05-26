Public Class clsMuestraAuxMovimiento
    Public Sub New(iD As Integer, nOMBRE As String, cANTIDAD As Integer, pRECIO As Double)
        Me.ID = iD
        Me.NOMBRE = nOMBRE
        Me.CANTIDAD = cANTIDAD
        Me.PRECIO = pRECIO
    End Sub

    Property ID As Integer
    Property NOMBRE As String
    Property CANTIDAD As Integer
    Property PRECIO As Double
End Class
