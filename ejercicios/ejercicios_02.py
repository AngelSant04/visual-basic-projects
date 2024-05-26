#Ingreso de numero
print("PRODUCTO: LAPTOP HP")
print("===================")
precio = float(input("Ingrese precio de Producto: "))
bandera = int(input("Paga con tarjeta: (1- Si, 2- No): "))
if(bandera == 1):
    aux = int(input("Tipo de Tarjeta: (1- Visa, 2- Mastercard, 3- Otro): "))
    if(aux == 1 or aux == 2):
        descuento = 0.15 * precio
        print("El descuento es de ",descuento," el precio a pagar es: ",(precio - descuento))       
    else:
        if(aux == 3):
            descuento = 0.05 * precio
            print("El descuento es de ",descuento," el precio a pagar es: ",(precio - descuento)) 
        else:
            print("Valor Ingresado no es correcto")
else:
    if(bandera == 2):
        print("Gracias por la compra, debe pagar: ", precio)
    else:
        print("Valor Ingresado no es correcto")