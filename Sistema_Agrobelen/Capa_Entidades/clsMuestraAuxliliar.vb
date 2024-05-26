Public Class clsMuestraAuxliliar
    Public Sub New(iD As Integer, iD_ALMACEN As Integer, nOMBRE As String, cANTIDAD As Integer, pRECIO As Double, iMPORTE As Double)
        Me.ID = iD
        Me.ID_ALMACEN = iD_ALMACEN
        Me.NOMBRE = nOMBRE
        Me.CANTIDAD = cANTIDAD
        Me.PRECIO = pRECIO
        Me.IMPORTE = iMPORTE
    End Sub

    Property ID As Integer
    Property ID_ALMACEN As Integer
    Property NOMBRE As String
    Property CANTIDAD As Integer
    Property PRECIO As Double
    Property IMPORTE As Double

End Class
