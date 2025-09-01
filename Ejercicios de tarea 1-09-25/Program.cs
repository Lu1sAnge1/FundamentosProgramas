//ejercicios de tarea 01

#region Ejercicios

//ejercicio 1
//CalculadoraDaño();
//ejercicio 2
//VendedorPociones();
//ejercicio 3
//DivisorBotin();
//ejercicio 4
//CalculadoraDaño2();
//ejercicio 5
//VendedorPociones2();
//ejercicio 6
//DivisorBotin2();
//ejercicio 7
//MiniAventura();
//ejercicio 8
MiniAventura2();

#endregion


#region Soluciones
//ejercicio 1
//calcular la suma de daño y fuerza
void CalculadoraDaño() {
    Console.WriteLine("Ingresa tu Daño: ");
    string input =  Console.ReadLine();

    Console.WriteLine("Ingresa tu Fuerza ");
    string input2 =  Console.ReadLine();


    bool  isValid;
    bool  isValid2;
    float daño;
    float fuerza;
    float dañof;

    isValid = float.TryParse(input, out daño);
    isValid2 = float.TryParse(input2, out fuerza);

    if (isValid == true && isValid2 == true)
    {
        dañof = daño + fuerza;
        Console.Write($"Tu daño final es: {dañof}");
    }

    else if (isValid == false && isValid2 == true)
    {
        Console.Write("Los valores de daño son incorrectos ");
    }
    else if (isValid == true  && isValid2 == false)
    {
        Console.Write("Los valores de fuerza son incorrectos ");
    }
    else
    {
        Console.Write("Ambos valores son incorrectos ");
    }

}

//ejercicio 2
//pedir al usuario cantidad de pociones a comprar, verificar si puede comprarlas
void VendedorPociones() {

    int precio = 55;
    int oro    = 550;

    Console.WriteLine($"El precio de las pociones es {precio}");
    Console.WriteLine($"Tienes {oro} de oro");
    Console.WriteLine("¿Cuantas pociones quieres comprar? ");
    string input = Console.ReadLine();

    bool isValid;
    int  compra;
    int  multi;
    int  resta;

    isValid = int.TryParse(input, out compra);

    if (isValid == true)
    {
        multi = compra * precio;
        resta = oro - multi;

        if (resta >= 0)
        {
            Console.Write($"Has comprado {input} pociones, te quedan {resta} de oro ");
        }

        else
        {
            Console.Write($"No tienes suficiente oro para comprar {input} pociones ");
        }

    }

    else
    {
        Console.Write("No ingresaste un numero valido ");
    }

}

//ejercicio 3
//dividir oro entre integrantes
void DivisorBotin() {

    Console.WriteLine("Ingresa la cantidad de oro");
    string input = Console.ReadLine();

    Console.WriteLine("Ingresa la cantidad de integrantes del equipo ");
    string input2 = Console.ReadLine();

    bool isValid;
    bool isValid2;
    int  oro;
    int  integrantes;
    int  division;
    int  sobrante;

    isValid = int.TryParse(input, out oro);
    isValid2 = int.TryParse(input2, out integrantes);


    if (isValid == true && isValid2 == true)
    {
        if (oro >= 0 && integrantes > 0)
        {

            division = oro / integrantes;
            sobrante = oro % integrantes;

            Console.WriteLine($"A cada integrante del equipo le corresponden {division} de oro");
            Console.WriteLine($"El oro sobrante es: {sobrante}");
        }
        else
        {
            Console.WriteLine("La cantidad de oro no puede ser negativa ni los integrantes deben ser menor a 1");
        }
    }
    else if (isValid == false && isValid2 == true)
    {
        Console.Write("No ingresaste un numero de oro valido ");
    }
    else if (isValid == true && isValid2 == false)
    {
        Console.Write("No ingresaste un numero de integrantes valido ");
    }
    else
    {
        Console.Write("Ninguno de los valores ingresados son validos ");
    }
}

//ejercicio 4
//calcular daño con critico
void CalculadoraDaño2() {

    Console.WriteLine("Si haces un critico tu daño es un 1.5 de tu daño total");

    Console.WriteLine("Ingresa tu Daño: ");
    string input =  Console.ReadLine();

    Console.WriteLine("Ingresa tu Fuerza ");
    string input2 =  Console.ReadLine();

    bool  isValid;
    bool  isValid2;
    float daño;
    float fuerza;
    float dañof;
    float critico = 1.5f;
    float dañocritico;

    isValid  = float.TryParse(input, out daño);
    isValid2 = float.TryParse(input2, out fuerza);

    if (isValid == true && isValid2 == true)
    {
        dañof = daño + fuerza;
        dañocritico = dañof * critico;

        Console.WriteLine($"Tu daño final es: {dañof}");
        Console.Write($"Tu daño con critico es: {dañocritico}");
    }

    else if (isValid == false && isValid2 == true)
    {
        Console.Write("Los valores de daño son incorrectos ");
    }
    else if (isValid == true  && isValid2 == false)
    {
        Console.Write("Los valores de fuerza son incorrectos ");
    }
    else
    {
        Console.Write("Ambos valores son incorrectos ");
    }

}

//ejercicio 5
//Generar recibo de compra de pociones
void VendedorPociones2() {
    int precio = 55;
    int oro    = 550;

    Console.WriteLine($"El precio de las pociones es {precio}");
    Console.WriteLine($"Tienes {oro} de oro");
    Console.WriteLine("Ingresa nombre del comprador");
    string nombre = Console.ReadLine();
    Console.WriteLine("¿Cuantas pociones quieres comprar? ");
    string input = Console.ReadLine();

    bool isValid;
    int  compra;
    int  multi;
    int  resta;

    isValid = int.TryParse(input, out compra);

    if (isValid == true)
    {
        multi = compra * precio;
        resta = oro - multi;

        if (resta >= 0)
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Gracias por comprar en Potion Land");
            Console.WriteLine($"Cliente {nombre}");
            Console.Write($"Compra {compra} pociones ");
            Console.WriteLine($"   {precio} de oro c/u");
            Console.WriteLine($"                       Total: {multi}");
            Console.WriteLine("___________________________________");

            Console.WriteLine($"Te sobran {resta} de oro");

        }

        else
        {
            Console.Write($"No tienes suficiente oro para comprar {input} pociones ");
        }

    }

    else
    {
        Console.Write("No ingresaste un numero valido ");
    }
}

//ejercicio 6
//pedir nombre del lugar y mostrar resumen de la obtencion del botin
void DivisorBotin2() {

    Console.WriteLine("Ingresa la cantidad de oro");
    string input = Console.ReadLine();

    Console.WriteLine("Ingresa la cantidad de integrantes del equipo ");
    string input2 = Console.ReadLine();

    Console.WriteLine("Ingresa el nombre del lugar donde se obtuvo el botin");
    string lugar = Console.ReadLine();

    bool isValid;
    bool isValid2;
    int  oro;
    int  integrantes;
    int  division;
    int  sobrante;

    isValid  = int.TryParse(input, out oro);
    isValid2 = int.TryParse(input2, out integrantes);


    if (isValid == true && isValid2 == true)
    {
        if (oro >= 0 && integrantes > 0)
        {

            division = oro / integrantes;
            sobrante = oro % integrantes;


            Console.WriteLine($"Un equipo de {integrantes} exploradores se encontraron {oro} de oro en {lugar}");
            Console.WriteLine($"A cada integrante del equipo le corresponden {division} de oro");
            Console.WriteLine($"El oro sobrante es: {sobrante}");
        }
        else
        {
            Console.WriteLine("La cantidad de oro no puede ser negativa ni los integrantes deben ser menor a 1");
        }
    }
    else if (isValid == false && isValid2 == true)
    {
        Console.Write("No ingresaste un numero de oro valido ");
    }
    else if (isValid == true && isValid2 == false)
    {
        Console.Write("No ingresaste un numero de integrantes valido ");
    }
    else
    {
        Console.Write("Ninguno de los valores ingresados son validos ");
    }
}

//ejercicio 7
//MiniAventura1
void MiniAventura() {

    Console.WriteLine("Te acabas de despertar en una habitacion cerrada con una puerta en cada pared, cada puerta tien una direccion marcada  norte, sur, este, oeste");
    Console.WriteLine("Escribe a que puerta quieres entrar:");
    string input = Console.ReadLine();

    if (input == "norte" || input == "NORTE" )
    {
        Console.WriteLine("Entras en a puerta norte, te encuentras con un cuadro de aspecto extraño");
    }
    else if (input == "este" || input == "ESTE")
    {
        Console.WriteLine("Entras en la puerta este, observas un cuarto vacio con un closet cerrado");
    }
    else if (input == "oeste" ||  input == "OESTE")
    {
        Console.WriteLine("Entras en la puerta oeste, Te encuentras con una puerta a lo que parece un sotano");
    }
    else if (input == "sur"  || input == "SUR")
    {
        Console.WriteLine("Observas una mesa con una caja fuerte encima");
    }
    else
    {
        Console.WriteLine("No ingresaste un comando valido");
    }
}

//ejercicio8
//MiniAventura2
void MiniAventura2() {

    Console.WriteLine("Te acabas de despertar en una habitacion cerrada con una puerta en cada pared, cada puerta tien una direccion marcada  norte, sur, este, oeste");
    Console.WriteLine("Escribe a que puerta quieres entrar:");
    string input = Console.ReadLine();

    if (input == "norte" || input == "NORTE" )
    {
        Console.WriteLine("Entras en a puerta norte, te encuentras con un cuadro de aspecto extraño");
    }
    else if (input == "este" || input == "ESTE")
    {
        Console.WriteLine("Entras en la puerta este, observas un cuarto vacio con un closet cerrado");
    }
    else if (input == "oeste" ||  input == "OESTE")
    {
        Console.WriteLine("Entras en la puerta oeste, Te encuentras con una puerta a lo que parece un sotano");
    }
    else if (input == "sur"  || input == "SUR")
    {
        Console.WriteLine("Observas una mesa con una caja fuerte encima");
        Console.WriteLine("La caja fuerte tiene una contraseña, al lado tienes dos ");
    }
    else
    {
        Console.WriteLine("No ingresaste un comando valido");
    }
}

#endregion
