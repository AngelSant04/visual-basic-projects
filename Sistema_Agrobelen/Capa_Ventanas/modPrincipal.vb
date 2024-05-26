Imports Capa_Entidades
Module modPrincipal
    Public idCategoria As Integer
    Public empleadoGlobal As clsEmpleado
    Public proveedorGlobal As clsProveedor
    Public clienteGlobal As clsCliente
    Public productoGlobal As clsProducto
    Public inventarioGlobal As clsInventario
    Public listaProductosAux As New List(Of clsMuestraAuxliliar)
    Public listaProductosAuxVenta As New List(Of clsMuestraAuxiliarVenta)
    Public listaProductosAuxMovimiento As New List(Of clsMuestraAuxMovimiento) 'ARRAYLIST
    Public sucursalAux As Integer
    Public bandGlobal As Integer

    'ArrayList te permite ingresar distintas clases es decir puede tener una clase Empleado, como
    'puede tener una clase Producto

    'LIST es un tipo de arraylist pero que solo acepta un tipo de clase
End Module
