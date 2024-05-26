Public Class ClsProgramacion
    Private _Dia() As Integer
    Private _Hora As Integer
    Private _TipoPrograma As String

    Public Sub New(dias() As Integer, hora As String, tipo As String)
        _Dia = dias
        _Hora = hora
        _TipoPrograma = tipo
    End Sub

    Public Sub setHora(horaAux As Integer)
        _Hora = horaAux
    End Sub

    Public Function mostrar() As String
        Dim contenido As String = ""
        For i = 0 To _Dia.Length - 1
            contenido = contenido & " - " & _Dia(i)
        Next
        Return contenido & " - " & _Hora & " - " & _TipoPrograma
    End Function

End Class
