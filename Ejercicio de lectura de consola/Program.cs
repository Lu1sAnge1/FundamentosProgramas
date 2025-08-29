// ejercicios de lectura de consola


#region Ejercicios

//Ejercicio 1
//PreguntarNombre();
//Ejercicio 2
//PreguntarNombre2();
//Ejercicio 3
//ConversionEdad();
//Ejercicio 4
//PedirAñoYaltura();
//Ejercicio 5
//ValidarEdad();
//Ejercicio 6
PedirNivel();
#endregion


#region Soluciones

//Ejercicio 1
//pregunta nombre al usuario
void PreguntarNombre() {

    string nombre;

    Console.Write("Escribe tu nombre: ");
    nombre = Console.ReadLine();

    Console.WriteLine($"Hola {nombre}");
}

//Ejercicio 2
//pregunta nombre y lugar de nacimiento
void PreguntarNombre2() {
    string nombre;
    String nacimiento;

    Console.Write("Escribe tu nombre: ");
    nombre = Console.ReadLine();

    Console.Write("escribe tu lugar de nacimiento: ");
    nacimiento = Console.ReadLine();

    Console.WriteLine($"Hola {nombre}, naciste en {nacimiento}");

}

//Ejercicio 3
//pedir edad al usuario y convertir a numero
void ConversionEdad() {
    Console.Write("Ingresa tu edad: ");
    String input = Console.ReadLine();

    bool isValid;
    int  edad;

    isValid = int.TryParse(input, out edad);

    Console.WriteLine($"El valor a convertir es: {input}");
    Console.WriteLine($"¿Es un valor valido?: {isValid}");
    Console.WriteLine($"El valor convertido es: {edad}");

}

//Ejercicio 4
//Pedir año con short y altura con float
void PedirAñoYaltura() {
    Console.Write("Ingresa tu edad: ");
    String input3 = Console.ReadLine();

    Console.Write("Ingresa el año en el que naciste: ");
    String input = Console.ReadLine();

    Console.Write("Ingresa tu altura: ");
    String input2 = Console.ReadLine();

    bool  isValid;
    bool  isvalid2;
    short año;
    float altura;
    bool  isValid3;
    int   edad;

    isValid  = short.TryParse(input, out año);
    isvalid2 = float.TryParse(input2, out altura);
    isValid3  = int.TryParse(input3, out edad);

    Console.WriteLine($"El valor a convertir es: {input3}");
    Console.WriteLine($"¿Es un valor valido?: {isValid3}");
    Console.WriteLine($"El valor convertido es: {edad}");

    Console.WriteLine($"El primer valor a convertir es: {input}");
    Console.WriteLine($"¿Es un valor valido?: {isValid}");
    Console.WriteLine($"El valor convertido es: {año}");

    Console.WriteLine($"El segundo valor a convertir es: {input2}");
    Console.WriteLine($"¿Es un valor valido?: {isvalid2}");
    Console.WriteLine($"El valor convertido es: {altura}");

}

//Ejercicio 5
//pedir edad y sumarle 10 si es valida
void ValidarEdad() {

    Console.WriteLine("Ingresa tu edad: ");
    string input = Console.ReadLine();

    bool isValid;
    int edad;

    isValid = int.TryParse(input, out edad);
    if (isValid)
    {
        edad = edad + 10;
        Console.WriteLine($"La edad en 10 años es: {edad}");
    }

    else
    {
       Console.WriteLine($"El valor de \"{input}\" no es un valor valido");
    }

}

//Ejercicio 6
//pedir un nivel y si es valido multiplicar por 5
void PedirNivel() {

    Console.WriteLine("Ingresa tu nivel: ");
    string input = Console.ReadLine();

    bool isValid;
    byte nivel;

    isValid = byte.TryParse(input, out nivel);

    if (isValid == true)
    {
        nivel = (byte)(nivel * 5);

        Console.WriteLine($"La vida es: {nivel}");;

    }
    else
    {
        Console.WriteLine($"El nivel {input} no es un valor valido");
    }

}



#endregion
