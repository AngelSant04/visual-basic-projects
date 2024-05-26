Public Class clsCurso
    Private _ID As String
    Private _nombre As String
    Private _duracion As Integer
    Private _costo As Double
    Private _band() As Integer
    Private _total, _contador As Integer
    Private _Alumno() As clsAlumno

    Public Sub New(id As String, nombre As String, duracion As Integer, costo As Double)
        _ID = id
        _nombre = nombre
        _duracion = duracion
        _costo = costo
        _contador = 0

        ReDim Preserve _band(_duracion - 1)

        For i = 0 To duracion - 1
            _band(i) = 0
        Next

    End Sub

    Public Sub actualizarAlumno(alumno As clsAlumno)
        ReDim Preserve _Alumno(_total)
        _Alumno(_total) = alumno
        _total = _total + 1
    End Sub

    Public Sub actualizarCuota()
        For i = 0 To _duracion - 1
            If _band(i) = 0 Then
                _band(i) = 1
                Exit For             'SALE DEL BUCLO CUANDO ENCUENTRA EL PRIMER 0 
                'ES DECIR CUANDO VE EL PRIMER MES QUE NO PAGO             
            End If
        Next
    End Sub

    'Public Property GSBandPago As Integer
    '    Get
    '        Return _band
    '    End Get
    '    Set(value As Integer)
    '        _band = value
    '    End Set
    'End Property

    Public Property GSId As String
        Get
            Return _ID
        End Get
        Set(value As String)
            _ID = value
        End Set
    End Property
    Public Property GSNombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property GSDuracion As Integer
        Get
            Return _duracion
        End Get
        Set(value As Integer)
            _duracion = value
        End Set
    End Property

    Public Property GSCosto As Double
        Get
            Return _costo
        End Get
        Set(value As Double)
            _costo = value
        End Set
    End Property

    Public Function mostrar() As String
        Return _ID & " - " & _nombre & " - " & _duracion & " - " & _costo
    End Function
    Public Function presentar() As String
        Dim contenido As String = ""
        For i = 0 To _total - 1
            contenido = contenido & _Alumno(i).mostrar & vbCrLf
        Next
        Return contenido
    End Function

    Public Function mostrarPagos() As String
        Dim contenido As String = ""
        For i = 0 To _duracion - 1
            contenido = contenido & _band(i) & vbCrLf
        Next
        Return contenido
    End Function

    Public Function buscarAlumno(dniAux As String) As Integer
        For i = 0 To _total - 1
            If _Alumno(i).GSDNI = dniAux Then
                Return i
            End If
        Next
        Return -1
    End Function


End Class
