//ejercicios de escritura de consola
#region Ejercicios

//Ejercicio #1
//ArbolDeNavidad();
//Ejercicio #2
//BiografiaDePersonaje();
//Ejercicio #3
//AtributosDeArma();
//Ejercicio #4
//ArbolDeNavidadColor();
//BiografiaDePersonaje2();
//AtributosDeArma2();

#endregion

#region Soluciones

//Ejercicio #1
//generar un arbol de navidad en la consola
void ArbolDeNavidad() {
    Console.WriteLine("           *           ");
    Console.WriteLine("          ( )          ");
    Console.WriteLine("         (   )         ");
    Console.WriteLine("        ( *   )        ");
    Console.WriteLine("       (   * O )       ");
    Console.WriteLine("      (    O *  )      ");
    Console.WriteLine("     (___________)     ");
    Console.WriteLine("         |  |          ");
    Console.WriteLine("         |  |          ");
}

//Ejercicio #2
//imprimir datos de un personaje
void BiografiaDePersonaje() {
    string Nombre = "Shiki";
    byte   Edad = 22;
    string Ocupacion = "Hechicero";
    string Ubicacion = "Torre del reloj";

    Console.WriteLine($"Nombre:\t\t {Nombre}");
    Console.WriteLine($"Edad:\t\t {Edad}");
    Console.WriteLine($"Ocupacion:\t {Ocupacion}");
    Console.WriteLine($"Ubicacion:\t {Ubicacion}");
}

//Ejercicio #3
//imprimir atributos de un arma
void AtributosDeArma() {
    string  Nombre    = "DragonSlayer";
    string  Rareza    = "Legendaria";
    int     Daño      = 600;
    float   Velocidad = 256.5f;
    decimal Costo     = 340;


    Console.WriteLine($"Nombre:\t\t {Nombre}");
    Console.WriteLine($"Rareza:\t\t {Rareza}");
    Console.WriteLine($"Daño:\t\t {Daño}");
    Console.WriteLine($"Velocidad:\t {Velocidad}");
    Console.WriteLine($"Costo:\t\t {Costo}");

}

//Ejercicio #4
//dar color a arbol de navidad
void ArbolDeNavidadColor() {

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("           *           ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("          ( )          ");
    Console.WriteLine("         (   )         ");
    Console.Write    ("        (");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write    (" *");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("   )        ");
    Console.Write    ("       (");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write    ("   * O ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(")");
    Console.Write("      (");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("    O *");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("  )      ");
    Console.WriteLine("     (___________)     ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("         |  |          ");
    Console.WriteLine("         |  |          ");
    Console.ResetColor();
}

//Ejercicio #5
//Dar historia al personaje
void BiografiaDePersonaje2() {
    string Nombre    = "Shiki";
    byte   Edad      = 22;
    string Ocupacion = "Hechicero";
    string Ubicacion = "Torre del reloj";

    Console.WriteLine($"Dentro de la parte más alta de la {Ubicacion} se encuentra {Nombre}. ");
    Console.WriteLine($"{Nombre} es un {Ocupacion} de gran renombre, apesar de solo haber cumplido {Edad} años recientemente.");

}

//Ejercicio #6
//Estilizar atributos de arma
void AtributosDeArma2() {
    string  Nombre    = "DragonSlayer";
    string  Rareza    = "Legendaria";
    int     Daño      = 600;
    float   Velocidad = 256.5f;
    decimal Costo     = 340;
    String  separador = "-------------------------------";

    Console.WriteLine(separador);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Nombre:\t\t {Nombre}");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Rareza:\t\t {Rareza}");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"Daño:\t\t {Daño}");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Velocidad:\t {Velocidad}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Costo:\t\t {Costo}");
    Console.ResetColor();
    Console.WriteLine(separador);

}



#endregion
