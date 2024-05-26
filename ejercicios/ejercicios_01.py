#Ingreso de nota
print("Ingrese Nota de estudiante (1-10): ")
nota = input()
#Validacion con IF
if(int(nota) > 10 or int(nota) < 1):
    print("nota ingresada no es correcta")
else:
    if(int(nota) < 5):
        print("INSUFICIENTE")
    else:
        print("SUFICIENTE")

