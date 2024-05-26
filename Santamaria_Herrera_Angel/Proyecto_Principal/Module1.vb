Imports Clases
Module Module1

    Sub llenarProducto(coleccion As clsColeccionProductos)

        Dim producto As clsProducto
        Dim Codigo, descripcion, tipoPresentacion, adquisicion As String
        Dim tipoProducto, cantidad As Integer

        Console.WriteLine("Ingrese Codigo del Producto: ")
        Codigo = Console.ReadLine
        If coleccion.buscarProducto(Codigo) = -1 Then
            Console.WriteLine("Ingrese Descripcion del Producto: ")
            descripcion = Console.ReadLine
            Console.WriteLine("Ingrese Tipo de Producto: 1-PERCIBLE 2-NO PERCIBLE")
            tipoProducto = Console.ReadLine
            Console.WriteLine("Ingrese Tipo de Presentacion de Producto: ")
            tipoPresentacion = Console.ReadLine
            Console.WriteLine("Ingrese Cantidad de Producto: ")
            cantidad = Console.ReadLine
            Console.WriteLine("Ingrese de Donde se obtuvo el Producto(Nombre de empresa - Municipalidad): ")
            adquisicion = Console.ReadLine

            producto = New clsProducto(Codigo, descripcion, tipoProducto, tipoProducto, cantidad, adquisicion)

            coleccion.agregar(producto)
            Console.WriteLine("PRODUCTO REGISTRADO")
        Else
            Console.WriteLine("CODIGO DE PRODUCTO YA REGISTRADO")
        End If

    End Sub

    Sub llenarComunidad(coleccion As clsColeccionComunidad)

        Dim comunidad As clsComunidad
        Dim nombre, distrito, nombRepresentante As String
        Dim tipoComunidad As Integer


        Console.WriteLine("Ingrese Nombre de Comunidad: ")
        nombre = Console.ReadLine
        If coleccion.buscarComunidad(nombre) = -1 Then
            Console.WriteLine("Ingrese Distrito Donde Pertenece: ")
            distrito = Console.ReadLine
            Console.WriteLine("Ingrese Nombre de Representante: ")
            nombRepresentante = Console.ReadLine
            Console.WriteLine("Ingrese Tipo de Comunidad: 1- Pueblos Joven 2- Asociacion de Vaso de Leche
                                3- Asociacion de Ollas Comunes 4- Cuadras de Viviendas Agrupadas")
            tipoComunidad = Console.ReadLine

            comunidad = New clsComunidad(nombre, distrito, nombRepresentante, tipoComunidad)

            coleccion.agregar(comunidad)
            Console.WriteLine("COMUNIDAD REGISTRADA")
        Else
            Console.WriteLine("CODIGO DE PRODUCTO YA REGISTRADO")
        End If

    End Sub

    Function opciones()
        Dim op As Integer

        Console.WriteLine()
        Console.WriteLine("1- Registrar Producto")
        Console.WriteLine("2- Registrar Comunidad")
        Console.WriteLine("3- Agregar Acta")
        Console.WriteLine("4- presentar actas y productos")
        'Console.WriteLine("5- Presentar Alumnos matriulados en un curso")
        'Console.WriteLine("6- Realizar pago de mensualidad")
        'Console.WriteLine("7- Mostrar datos de alumno y sus cursos")
        Console.WriteLine("Seleccione Opcion: ")
        op = Console.ReadLine
        Return op
    End Function

    Sub Main()
        Dim coleccionProductos As clsColeccionProductos
        Dim coleccionComunidades As clsColeccionComunidad
        Dim coleccionActas As clsColeccionActas
        Dim op As Integer
        coleccionProductos = New clsColeccionProductos()
        coleccionComunidades = New clsColeccionComunidad()
        coleccionActas = New clsColeccionActas()

        Do
            op = opciones()
            Select Case op
                Case 1
                    llenarProducto(coleccionProductos)
                Case 2
                    llenarComunidad(coleccionComunidades)
                Case 3
                    agregarActa(coleccionActas, coleccionProductos, coleccionComunidades)
                Case 4
                    Console.WriteLine(coleccionActas.presentar())
                    Console.WriteLine(coleccionProductos.presentar())
                    'Case 5
                    '    presentarAlumnosPorCurso(coleccionCursos, coleccionAlumnos)
                    'Case 6
                    '    pagarMensualidad(coleccionCursos, coleccionAlumnos)
                    'Case 7
                    '    presentarAlumnoCompleto(coleccionCursos, coleccionAlumnos)
            End Select
        Loop

        Console.ReadKey()
    End Sub

    Sub agregarActa(coleccionActas As clsColeccionActas, ByRef coleccionProductos As clsColeccionProductos, coleccionComunidades As clsColeccionComunidad)

        Dim coleccionAuxiliar As clsColeccionProductos
        Dim acta As clsActa
        Dim codigo, fecha, nombreComunidad, nombreRepresentanteComunidad, representanteMunicipalidad As String
        Dim productoAux As clsProducto
        Dim productoAux2 As clsProducto
        Dim cantidad, opcion, pos, band As Integer

        band = 0

        Console.WriteLine("Ingrese fecha de Entrega:")
        fecha = Console.ReadLine
        Console.WriteLine("*****COMUNIDADEDS REGISTRADOS*****")
        Console.WriteLine("")
        Console.WriteLine(coleccionComunidades.presentar())
        Console.WriteLine("")
        Console.WriteLine("======================================")
        Console.WriteLine("Ingrese Comunidad Beneficiaria: ")
        nombreComunidad = Console.ReadLine
        pos = coleccionComunidades.buscarComunidad(nombreComunidad)
        If pos = -1 Then
            Console.WriteLine("Comunidad no Encontrada Registrala Antes")
        Else
            nombreRepresentanteComunidad = coleccionComunidades.regresarNombre(pos)
            Console.WriteLine("Ingrese Representante de la Municipalidad: ")
            representanteMunicipalidad = Console.ReadLine

            Do
                Console.WriteLine("*****PRODUCTOS REGISTRADOS*****")
                Console.WriteLine("")
                Console.WriteLine(coleccionProductos.presentar())
                Console.WriteLine("")
                Console.WriteLine("======================================")
                Console.WriteLine("Ingrese Codigo de Productos a enviar: ")
                codigo = Console.ReadLine

                If coleccionProductos.buscarProducto(codigo) = -1 Then
                    Console.WriteLine("PRODUCTO NO ENCONTRADO")
                Else
                    Console.WriteLine("Ingrese Cantidad de Productos a Enviar: ")
                    cantidad = Console.ReadLine

                    coleccionAuxiliar = New clsColeccionProductos()

                    productoAux = coleccionProductos.regresarProducto(codigo)
                    productoAux2 = productoAux
                    productoAux2.setCantidad(cantidad)

                    coleccionProductos.actualizarStock(codigo, cantidad)

                    coleccionAuxiliar.agregar(productoAux2)

                    Console.WriteLine("Desea Ingresar Otro Producto a enviar: 1- Si 2- No ")
                    opcion = Console.ReadLine
                    band = 1
                End If
            Loop Until opcion = 2
            If band = 0 Then
                Console.WriteLine("Acta no Registrada")
            Else
                acta = New clsActa(fecha, nombreRepresentanteComunidad, representanteMunicipalidad, coleccionAuxiliar)
                coleccionActas.agregar(acta)
                Console.WriteLine("ACTA REGISTRADA")
            End If

        End If


    End Sub

End Module
