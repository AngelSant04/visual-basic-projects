Imports Libreria_Clases
Module Module1

    Sub llenarVehiculo(coleccion As clsColeccionVehiculos)
        Dim tipo As Integer
        Dim placa, marca, modelo As String

        Console.WriteLine("Ingrese Placa del Vehiculo: ")
        placa = Console.ReadLine
        If coleccion.buscarVehiculo(placa) = -1 Then
            Console.WriteLine("Ingrese Marca del Vehiculo: ")
            marca = Console.ReadLine
            Console.WriteLine("Ingrese Modelo del vehiculo: ")
            modelo = Console.ReadLine
            Console.WriteLine("Ingrese Tipo de Vehiculo: 1- Auto 2-Combi")
            tipo = Console.ReadLine
            If tipo = 1 Then
                Dim tipoAuto As Integer
                Console.WriteLine("Ingrese tipo de Auto: 1-Automatico 2-Mecanico")
                tipoAuto = Console.ReadLine
                Dim auto As clsAuto
                auto = New clsAuto(placa, marca, modelo, tipoAuto)
                coleccion.agregar(auto)
                Console.WriteLine("Auto Registrado")
            Else
                Dim pasajeros As Integer
                Console.WriteLine("Ingrese Cantidad de pasajeros: ")
                pasajeros = Console.ReadLine
                Dim combi As clsCombi
                combi = New clsCombi(placa, marca, modelo, pasajeros)
                coleccion.agregar(combi)
                Console.WriteLine("Combi Registrada")
            End If
        Else
                Console.WriteLine("Placa de Vehiculo ya registrada")
        End If

    End Sub

    Function opciones()
        Dim op As Integer

        Console.WriteLine()
        Console.WriteLine("1- Registrar Vehiculo")
        Console.WriteLine("2- Presentar Vehiculos")
        Console.WriteLine("3- Presentar Vehiculos por Marca")
        Console.WriteLine("Seleccione Opcion: ")
        op = Console.ReadLine
        Return op
    End Function

    Sub Main()
        Dim coleccionVehiculos As clsColeccionVehiculos

        Dim op As Integer
        coleccionVehiculos = New clsColeccionVehiculos()

        Do
            op = opciones()
            Select Case op
                Case 1
                    llenarVehiculo(coleccionVehiculos)
                Case 2
                    Console.WriteLine(coleccionVehiculos.presentar())
                Case 3
                    presentarXMarca(coleccionVehiculos)
            End Select
        Loop

        Console.ReadKey()
    End Sub

    Public Sub presentarXMarca(coleccion As clsColeccionVehiculos)
        Dim marcaAux As String
        Dim pos As Integer
        Console.WriteLine("Ingrese Marca de Vehiculo: ")
        marcaAux = Console.ReadLine
        pos = coleccion.buscarVehiculoXMarca(marcaAux)
        If pos = -1 Then
            Console.WriteLine("Marca no encontrada")
        Else
            Console.WriteLine(coleccion.presentarXMarca(pos))
        End If

    End Sub

End Module
