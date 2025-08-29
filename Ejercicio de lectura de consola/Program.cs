// ejercicios de lectura de consola


#region Ejercicios

//Ejercicio 1
//PreguntarNombre();
PreguntarNombre2();
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



#endregion
