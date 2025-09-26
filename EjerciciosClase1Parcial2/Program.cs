//ejercicios clase1 parcial 2

#region Ejercicios

PedirNombreEdad();


#endregion






#region Soluciones

void PedirNombreEdad() {



    Console.WriteLine("ingresa tu nombre");
    var nombre = Console.ReadLine();

    Console.WriteLine("ingresa tu edad");
    var edad = Console.ReadLine();

    var edadf = int.TryParse(edad, out var edadi);

    var suma = edadi + 10;

    Console.WriteLine($"Tu nombre es {nombre} y tu edad en 10 años sera {suma} años");



}


#endregion
