//ejercicios de escritura de consola
#region Ejercicios

//Ejercicio #1
//ArbolDeNavidad();
//Ejercicio #2
BiografiaDePersonaje();

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

    Console.WriteLine("   Nombre :\t" + Nombre);
    Console.WriteLine("   Edad :\t" + Edad);
    Console.WriteLine("   Ocupacion :\t" + Ocupacion);
    Console.WriteLine("   Ubicacion :\t" + Ubicacion);
}
#endregion
