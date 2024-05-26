Imports Libreria_Clases

Module Module1

    Sub llenarObjeto(coleccion As ClsColeccionCuentas)

        Dim Cuenta As clsCuenta
        Dim num, DNI, propietario As String
        Dim saldo, tipoCuenta, op As Integer

        num = coleccion.getTotal + 1

        Console.WriteLine("Ingrese Dni: ")
        DNI = Console.ReadLine
        Console.WriteLine("Ingrese nombre del propietario: ")
        propietario = Console.ReadLine
        Console.WriteLine("Desea ingresar saldo 1:SI 2:NO")
        op = Console.ReadLine
        If op = 1 Then
            Console.WriteLine("Ingrese monto a ingresar: ")
            saldo = Console.ReadLine
        Else
            saldo = 0
        End If
        Console.WriteLine("Ingrese tipo de cuenta: 1.AHORROS 2.Otra cuenta")
        tipoCuenta = Console.ReadLine

        Cuenta = New clsCuenta(num, DNI, saldo, propietario, tipoCuenta)

        coleccion.agregar(Cuenta)
    End Sub

    Function opciones()
        Dim op As Integer

        Console.WriteLine()
        Console.WriteLine("1- Agregar Cuenta")
        Console.WriteLine("2- Presentar Coleccion")
        Console.WriteLine("3- Buscar por numero de cuenta")
        Console.WriteLine("4-Presentar por saldos")
        Console.WriteLine("Seleccione Opcion: ")
        op = Console.ReadLine
        Return op
    End Function

    Sub Main()
        Dim coleccion As ClsColeccionCuentas
        Dim op As Integer
        coleccion = New ClsColeccionCuentas()

        Do
            op = opciones()
            Select Case op
                Case 1
                    llenarObjeto(coleccion)
                Case 2
                    Console.WriteLine(coleccion.presentar())
                Case 3
                    'buscarXnumero(coleccion)
                Case 4
                    'presentarXsaldos(coleccion)
            End Select
        Loop

        Console.ReadKey()
    End Sub

End Module
