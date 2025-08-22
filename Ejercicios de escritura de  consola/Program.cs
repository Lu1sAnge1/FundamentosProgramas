//ejercicios de escritura de consola
#region Ejercicios

//Ejercicio #1
//ArbolDeNavidad();
//Ejercicio #2
//BiografiaDePersonaje();
//Ejercicio #3
AtributosDeArma();

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


#endregion
