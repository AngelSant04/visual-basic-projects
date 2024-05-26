Imports Clases
Module Module1

    Sub llenarObjeto(coleccion As ClsColeccionCanal)

        Dim Canal As clsCanal
        Dim nombre As String
        Dim calidad As Integer

        Console.WriteLine("Ingrese Nombre de Canal: ")
        nombre = Console.ReadLine
        If coleccion.buscarCanal(nombre) = -1 Then
            Console.WriteLine("Ingrese Calidad del canal: 1-HD 2-4K")
            calidad = Console.ReadLine

            Canal = New clsCanal(nombre, calidad)

            coleccion.agregar(Canal)
        Else
            Console.WriteLine("CANAL YA EXISTENTE")
        End If

    End Sub

    Sub llenarPrograma(coleccion As ClsColeccionCanal, pos As Integer)

        Dim programa As ClsPrograma
        Dim programacion As ClsProgramacion
        Dim tipoTransmision, tamanio, hora As Integer
        Dim nombrePrograma, nombreDirector, tipoPrograma As String
        Dim dias(-1) As Integer

        Console.WriteLine("=====LLENADO DE DATOS PROGRAMA=====")
        Console.WriteLine("Ingrese Nombre de Programa: ")
        nombrePrograma = Console.ReadLine
        Console.WriteLine("Ingrese Tipo de Transmision: 1- Señal Abierta 2- Cable")
        tipoTransmision = Console.ReadLine
        Console.WriteLine("Ingrese Nombre de Director: ")
        nombreDirector = Console.ReadLine

        'CREAR PROGRAMACION
        Console.WriteLine("Ingrese Cantidad de dias(1-7) que se reproducira este programa: ")
        tamanio = Console.ReadLine
        ReDim Preserve dias(tamanio - 1)        'Preserve?? Necesario en estos casos??

        For i = 0 To tamanio - 1
            Console.WriteLine("Ingrese dia a Reproducir: 1:Lunes 2:Martes 3:Miercoles 4:Jueves 5:Viernes 6:Sabado 7:Domingo ")
            dias(i) = Console.ReadLine
        Next

        Console.WriteLine("Ingrese Hora del Programa: ")
        hora = Console.ReadLine

        Console.WriteLine("Ingrese tipo de programa: ")
        tipoPrograma = Console.ReadLine

        programacion = New ClsProgramacion(dias, hora, tipoPrograma)

        programa = New ClsPrograma(tipoTransmision, nombrePrograma, nombreDirector, programacion)

        coleccion.agregarProgramaEnCanal(programa, pos)

        Console.WriteLine("Programa Registrado en Canal")
    End Sub

    Function opciones()
        Dim op As Integer

        Console.WriteLine()
        Console.WriteLine("1- Agregar Canal")
        Console.WriteLine("2- Presentar Canal")
        Console.WriteLine("3- Registrar un Programa en Canal")
        Console.WriteLine("4- Presentar programas de un canal")
        Console.WriteLine("5- Mostrar Programas por el tipo de señal")
        Console.WriteLine("6- Modificar Hora de Emision de Programa")
        Console.WriteLine("Seleccione Opcion: ")
        op = Console.ReadLine
        Return op
    End Function

    Sub Main()
        Dim coleccion As ClsColeccionCanal
        Dim op As Integer
        coleccion = New ClsColeccionCanal()

        Do
            op = opciones()
            Select Case op
                Case 1
                    llenarObjeto(coleccion)
                Case 2
                    Console.WriteLine(coleccion.presentar())
                Case 3
                    registrarPrograma(coleccion)
                Case 4
                    presentarCanal(coleccion)
                Case 5
                    presentarXTipo(coleccion)
                Case 6
                    modificarHora(coleccion)
            End Select
        Loop

        Console.ReadKey()
    End Sub

    Sub modificarHora(coleccion As ClsColeccionCanal)
        Dim canalAux As String
        Dim pos, posPrograma As Integer
        Dim ProgramaAux As String
        Dim horaAux As Integer

        Console.WriteLine("=====LISTADO DE CANALES=====")
        Console.WriteLine(coleccion.presentar())
        Console.WriteLine("Ingrese nombre de canal para ver programas: ")
        canalAux = Console.ReadLine

        pos = coleccion.buscarCanal(canalAux)

        If pos = -1 Then
            Console.WriteLine("CANAL NO ENCONTRADO")
        Else
            Console.WriteLine("*****LISTADO DE PROGRAMAS*****")
            Console.WriteLine(coleccion.vistaProgramas(pos))
            Console.WriteLine("===============================")
            Console.WriteLine("Ingrese programa para modificar hora de emision: ")
            ProgramaAux = Console.ReadLine

            posPrograma = coleccion.buscarPrograma(pos, ProgramaAux)

            If posPrograma = -1 Then
                Console.WriteLine("Programa no Encontrado")
            Else
                Console.WriteLine("DATOS DE PROGRAMA ESCOGIDO")
                Console.WriteLine("")
                Console.WriteLine(coleccion.verPrograma(pos, posPrograma))
                Console.WriteLine("")
                Console.WriteLine("===============================")
                Console.WriteLine("Ingrese nuevo horario para este programa: ")
                horaAux = Console.ReadLine

                coleccion.cambiarHora(pos, posPrograma, horaAux)

                Console.WriteLine("Hora de Programa Cambiado")
                Console.WriteLine("==============================")
                Console.WriteLine(coleccion.verPrograma(pos, posPrograma))

            End If

        End If
    End Sub

    Sub presentarXTipo(coleccion As ClsColeccionCanal)
        Dim tipoAux As Integer
        Console.WriteLine("Ingrese tipo de Señal para ver Programas: 1-Abierta 2-Cable")
        tipoAux = Console.ReadLine
        Console.WriteLine(coleccion.Tipo(tipoAux))
    End Sub

    Sub presentarCanal(coleccion As ClsColeccionCanal)
        Dim canalAux As String
        Dim pos As Integer

        Console.WriteLine("=====LISTADO DE CANALES=====")
        Console.WriteLine(coleccion.presentar())
        Console.WriteLine("Ingrese nombre de canal para ver programas: ")
        canalAux = Console.ReadLine

        pos = coleccion.buscarCanal(canalAux)

        If pos = -1 Then
            Console.WriteLine("Canal no Encontrado")
        Else
            Console.WriteLine(coleccion.vistaProgramas(pos))
        End If

    End Sub

    Sub registrarPrograma(coleccion As ClsColeccionCanal)

        Dim canalAux As String
        Dim pos As Integer

        Console.WriteLine("=====LISTADO DE CANALES=====")
        Console.WriteLine(coleccion.presentar())
        Console.WriteLine("Ingrese nombre de canal para agregar programas: ")
        canalAux = Console.ReadLine

        pos = coleccion.buscarCanal(canalAux)

        If pos = -1 Then
            Console.WriteLine("Canal no Encontrado")
        Else
            llenarPrograma(coleccion, pos)
        End If
    End Sub

End Module
