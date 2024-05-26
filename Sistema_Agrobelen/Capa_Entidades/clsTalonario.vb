Public Class clsTalonario
    Public Sub New(numTalonario As Integer, tipoTalonario As String, serie As String)
        Me.numTalonario = numTalonario
        Me.tipoTalonario = tipoTalonario
        Me.serie = serie
    End Sub

    Property numTalonario As Integer
    Property tipoTalonario As String
    Property serie As String


End Class
