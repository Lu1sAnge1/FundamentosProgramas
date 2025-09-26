//ejercicios clase1 parcial 2

#region Ejercicios

//ejercicio1
//PedirNombreEdad();

//ejercicio2
Fiesta();


#endregion






#region Soluciones

//ejercicio 1
void PedirNombreEdad() {



    Console.WriteLine("ingresa tu nombre");
    var nombre = Console.ReadLine();

    Console.WriteLine("ingresa tu edad");
    var edad = Console.ReadLine();

    var isValid = int.TryParse(edad, out var edadi);


    if (isValid && edadi > 17)
    {
        var suma = edadi + 10;

        Console.WriteLine($"Tu nombre es {nombre} y tu edad en 10 años sera {suma} años");
    }

    else
    {
        Console.WriteLine("No se pudo");
    }

}

//ejercicio2
void Fiesta() {
    Console.WriteLine("Tienes invitados?");
    var invitados = Console.ReadLine();
    Console.WriteLine("Tienes comida?");
    var comida = Console.ReadLine();
    Console.WriteLine("Tienes dinero?");
    var dinero = Console.ReadLine();
    Console.WriteLine("Tienes tiempo?");
    var tiempo = Console.ReadLine();

    var invitadosf = invitados.Trim().ToUpper();
    var comidadf = comida.Trim().ToUpper();
    var dinerof = dinero.Trim().ToUpper();
    var tiempof = tiempo.Trim().ToUpper();

    if (invitadosf == "SI" && comidadf == "SI" && dinerof == "SI" && tiempof == "SI")
    {
        Console.WriteLine("Puedes hacer la fiesta");
    }

    else if (invitadosf == "NO" || comidadf == "NO" || dinerof == "NO" || tiempof == "NO")
    {
        Console.WriteLine("No puedes hacer la fiesta");
    }
    else
    {
        Console.WriteLine("Alguna de tus respuestas no son validas");
    }

}


#endregion
