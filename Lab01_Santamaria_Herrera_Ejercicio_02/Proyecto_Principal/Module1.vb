Imports Clases

Module Module1

    Sub llenarObjeto(coleccion As clsColeccionCursos)

        Dim Curso As clsCurso
        Dim ID, nombre As String
        Dim duracion As Integer
        Dim costo As Double

        Console.WriteLine("Ingrese ID del Curso: ")
        ID = Console.ReadLine
        If coleccion.buscarCurso(ID) = -1 Then
            Console.WriteLine("Ingrese Nombre del Curso: ")
            nombre = Console.ReadLine
            Console.WriteLine("Ingrese Duracion del Curso: ")
            duracion = Console.ReadLine
            Console.WriteLine("Ingrese Costo del Curso")
            costo = Console.ReadLine

            Curso = New clsCurso(ID, nombre, duracion, costo)

            coleccion.agregar(Curso)
        Else
            Console.WriteLine("ID DE CURSO YA REGISTRADO")
        End If

    End Sub

    Sub llenarAlumno(DNI As String, coleccionCursos As clsColeccionCursos, coleccionAlumnos As clsColeccionAlumnos)

        Dim Alumno As clsAlumno
        Dim nombres, correo, cursoAux As String
        Dim DNIReal As String
        Dim band As Integer

        band = 0

        If DNI = "" Then
            Console.WriteLine("Ingrese DNI del Alumno: ")
            DNIReal = Console.ReadLine
            If coleccionAlumnos.buscarAlumno(DNIReal) = -1 Then
                Console.WriteLine("Ingrese Nombres del Alumno: ")
                nombres = Console.ReadLine
                Console.WriteLine("Ingrese Correo del Alumno: ")
                correo = Console.ReadLine

                Alumno = New clsAlumno(DNIReal, nombres, correo)

                band = 1
            Else
                Console.WriteLine("Alumno ya registrado anteriormente")
            End If

        Else
            DNIReal = DNI
            If coleccionAlumnos.buscarAlumno(DNIReal) = -1 Then
                Console.WriteLine("Ingrese Nombres del Alumno: ")
                nombres = Console.ReadLine
                Console.WriteLine("Ingrese Correo del Alumno: ")
                correo = Console.ReadLine

                Alumno = New clsAlumno(DNIReal, nombres, correo)

                band = 1
            Else
                Console.WriteLine("Alumno ya registrado anteriormente")
            End If

        End If

        If band = 0 Then
            Console.WriteLine("NO SE PUDO MATRICULAR ALUMNO")
        Else
            Console.WriteLine("*****Proceso de Matricula*****")
            Console.WriteLine("======================================")
            Console.WriteLine("*****CURSOS DISPONIBLES*****")
            Console.WriteLine("")
            Console.WriteLine(coleccionCursos.presentar())
            Console.WriteLine("")
            Console.WriteLine("======================================")
            Console.WriteLine("Ingrese ID del Curso: ")
            cursoAux = Console.ReadLine

            If coleccionCursos.buscarCurso(cursoAux) = -1 Then
                Console.WriteLine("Curso No Encontrado")
            Else

                coleccionAlumnos.agregar(Alumno)
                coleccionCursos.matricularAlumno(cursoAux, Alumno)

                Console.WriteLine("*****ALUMNO REGISTRADO*****")
            End If

        End If


    End Sub

    Sub agregarInscripcion(coleccionCursos As clsColeccionCursos, coleccionAlumnos As clsColeccionAlumnos)

        Dim Alumno As clsAlumno
        Dim DNI, cursoAux As String

        Console.WriteLine("Ingrese DNI del Alumno: ")
        DNI = Console.ReadLine
        If coleccionAlumnos.buscarAlumno(DNI) = -1 Then
            llenarAlumno(DNI, coleccionCursos, coleccionAlumnos)
        Else
            Console.WriteLine("*****Proceso de Matricula*****")
            Console.WriteLine("======================================")
            Console.WriteLine("*****CURSOS DISPONIBLES*****")
            Console.WriteLine("")
            Console.WriteLine(coleccionCursos.presentarCursosNoLlevados(DNI))
            Console.WriteLine("")
            Console.WriteLine("======================================")
            If coleccionCursos.presentarCursosNoLlevados(DNI) = "" Then
                Console.WriteLine("***ESTE ALUMNO LLEVO TODOS LOS CURSOS REGISTRADOS***")
            Else
                Console.WriteLine("Ingrese ID del Curso: ")
                cursoAux = Console.ReadLine
                If coleccionCursos.buscarCurso(cursoAux) = -1 Then
                    Console.WriteLine("Curso No Encontrado")
                Else
                    Alumno = coleccionAlumnos.copiarAlumno(DNI)

                    coleccionCursos.matricularAlumno(cursoAux, Alumno)

                    Console.WriteLine("*****ALUMNO REGISTRADO*****")
                End If
            End If
        End If

    End Sub


    Function opciones()
        Dim op As Integer

        Console.WriteLine()
        Console.WriteLine("1- Registar Curso")
        Console.WriteLine("2- Incribir Alumno")
        Console.WriteLine("3- Agregar Alumno a Curso")
        Console.WriteLine("4- Presentar Cursos para Alumno")
        Console.WriteLine("5- Presentar Alumnos matriulados en un curso")
        Console.WriteLine("6- Realizar pago de mensualidad")
        Console.WriteLine("7- Mostrar datos de alumno y sus cursos")
        Console.WriteLine("Seleccione Opcion: ")
        op = Console.ReadLine
        Return op
    End Function

    Sub Main()
        Dim coleccionCursos As clsColeccionCursos
        Dim coleccionAlumnos As clsColeccionAlumnos
        Dim op As Integer
        coleccionCursos = New clsColeccionCursos()
        coleccionAlumnos = New clsColeccionAlumnos()

        Do
            op = opciones()
            Select Case op
                Case 1
                    llenarObjeto(coleccionCursos)
                Case 2
                    llenarAlumno("", coleccionCursos, coleccionAlumnos)
                Case 3
                    agregarInscripcion(coleccionCursos, coleccionAlumnos)
                Case 4
                    presentarCursosParaAlumno(coleccionCursos, coleccionAlumnos)
                Case 5
                    presentarAlumnosPorCurso(coleccionCursos, coleccionAlumnos)
                Case 6
                    pagarMensualidad(coleccionCursos, coleccionAlumnos)
                Case 7
                    presentarAlumnoCompleto(coleccionCursos, coleccionAlumnos)
            End Select
        Loop

        Console.ReadKey()

    End Sub

    Sub presentarAlumnoCompleto(coleccionCursos As clsColeccionCursos, coleccionAlumnos As clsColeccionAlumnos)

        Dim idCurso As String

        presentarCursosParaAlumno(coleccionCursos, coleccionAlumnos)

        Console.WriteLine("Ingrese Curso para ver mensualidad: ")
        idCurso = Console.ReadLine

        If coleccionCursos.buscarCurso(idCurso) = -1 Then
            Console.WriteLine("Curso no encontrado")
        Else
            Console.WriteLine("=======================")
            Console.WriteLine(coleccionCursos.mostrarPagos(idCurso))
            Console.WriteLine("INFORMACION 1- PAGO 2- DEUDA")
        End If

    End Sub

    Sub pagarMensualidad(coleccionCursos As clsColeccionCursos, coleccionAlumnos As clsColeccionAlumnos)

        Dim idCurso As String

        presentarCursosParaAlumno(coleccionCursos, coleccionAlumnos)
        Console.WriteLine("Ingrese Curso para pagar mensualidad: ")
        idCurso = Console.ReadLine

        If coleccionCursos.buscarCurso(idCurso) = -1 Then
            Console.WriteLine("Curso no encontrado")
        Else
            coleccionCursos.actualizarPago(idCurso)

            Console.WriteLine("PAGO REALIZADO")

            Console.WriteLine("=======================")
            Console.WriteLine(coleccionCursos.mostrarPagos(idCurso))
            Console.WriteLine("INFORMACION 1- PAGO 2- DEUDA")
        End If

    End Sub


    Sub presentarAlumnosPorCurso(coleccionCursos As clsColeccionCursos, coleccionAlumnos As clsColeccionAlumnos)

        Dim idAux As String

        Console.WriteLine("*****CURSOS REGISTRADOS*****")
        Console.WriteLine("")
        Console.WriteLine(coleccionCursos.presentar())
        Console.WriteLine("")
        Console.WriteLine("======================================")
        Console.WriteLine("Ingrese ID de Curso para presentar sus Alumnos: ")
        idAux = Console.ReadLine

        If coleccionCursos.buscarCurso(idAux) = -1 Then
            Console.WriteLine("Curso no encontrado")
        Else
            Console.WriteLine("*****ALUMNOS MATRICULADOS EN EL CURSO*****")
            Console.WriteLine("")
            Console.WriteLine(coleccionCursos.presentarAlumnos(idAux))
            Console.WriteLine("")
            Console.WriteLine("======================================")
        End If

    End Sub

    Sub presentarCursosParaAlumno(coleccionCursos As clsColeccionCursos, coleccionAlumnos As clsColeccionAlumnos)

        Dim dniAux As String

        Console.WriteLine("*****ALUMNOS REGISTRADOS*****")
        Console.WriteLine("")
        Console.WriteLine(coleccionAlumnos.presentar())
        Console.WriteLine("")
        Console.WriteLine("======================================")
        Console.WriteLine("Ingrese DNI de alumno para presentar sus cursos: ")
        dniAux = Console.ReadLine

        If coleccionAlumnos.buscarAlumno(dniAux) = -1 Then
            Console.WriteLine("Alumno no encontrado")
        Else
            Console.WriteLine("*****CURSOS MATRICULADOS PARA EL ALUMNO*****")
            Console.WriteLine("")
            Console.WriteLine(coleccionCursos.presentarCursosMatriculados(dniAux))
            Console.WriteLine("")
            Console.WriteLine("======================================")
        End If

    End Sub

End Module
