// daclarar numero (0-10 ) y letra
//ejercicio con SWITCH

#region ejercicios
//ejercicio ejemplo switch
//ejemploSwitch();

//ejercicio 1
//ComparacionTemp();

//ejercicio 2
//CalculoDaño();

//ejercicio 3
SeleccionClases();

//ejercicio 5
//SeleccionEquipo();

#endregion


#region soluciones

//ejercicio ejemploswitch
void ejemploSwitch() {
    var num  = 1;
    var let  = "S";
    var num2 = 4;
    var let2 = "A";
    var num3 = 6;
    var let3 = "I";
    var num4 = 9;
    var let4 = "L";

    var random = new Random();
    var numer  = random.Next(0, 11);

//usando switch decir valor de letra o mensaje de error

    switch (numer)
    {
        case 1:
            Console.WriteLine("S");
            break;
        case 4:
            Console.WriteLine("A");
            break;
        case 6:
            Console.WriteLine("I");
            break;
        case 9:
            Console.WriteLine("L");
            break;
        default:
            Console.WriteLine("No se ha encontrado una letra correspondiente");
            break;
    }
}

//ejercicio 1
void ComparacionTemp() {

    Console.WriteLine("Ingrese temperatura en grados farenheit");
    var temp = Console.ReadLine();

    var isValid = float.TryParse(temp, out var tempf);

    if (isValid)
    {

        var convert = (tempf - 32f) * (5f / 9f);

        string mensaje = convert <= 0 ? "Puede conjelar el agua" : "No puede conjelar el agua";
        Console.WriteLine($"{convert} {mensaje}");
    }
    else
    {
        Console.WriteLine("No escribiste un numero valido");
    }

}

//ejercicio 2
void CalculoDaño() {

    var random = new Random();

    Console.WriteLine("Primer turno");
    var    num1    = random.Next(0, 101);
    string mensaje = num1 >= 50 ? "Acertaste" : "Fallaste";
    Console.WriteLine($"{mensaje}");

    Console.WriteLine("Segundo turno");
    num1    = random.Next(0, 101);
    string mensaje2 = num1 >= 50 ? "Acertaste" : "Fallaste";
    Console.WriteLine($"{mensaje2}");

    Console.WriteLine("Tercer turno");
    num1    = random.Next(0, 101);
    string mensaje3 = num1 >= 50 ? "Acertaste" : "Fallaste";
    Console.WriteLine($"{mensaje3}");

    Console.WriteLine("Cuarto turno");
    num1    = random.Next(0, 101);
    string mensaje4 = num1 >= 50 ? "Acertaste" : "Fallaste";
    Console.WriteLine($"{mensaje4}");

    Console.WriteLine("Quinto turno");
    num1    = random.Next(0, 101);
    string mensaje5 = num1 >= 50 ? "Acertaste" : "Fallaste";
    Console.WriteLine($"{mensaje5}");

}

//ejercicio 3
void SeleccionClases() {

    Console.WriteLine("Selecciona una clase:");
    Console.WriteLine("caballero, clerigo, mago, asesino, piromano");
    var clase = Console.ReadLine();

    var clasef = clase.Trim().ToUpper();

    int vida;
    int ataq;
    int def;


    switch (clasef)
    {
        case "CABALLERO":
            vida = 80;
            ataq = 50;
            def = 40;
            break;



    }





}

//ejercicio 5
void SeleccionEquipo() {

    Console.WriteLine("Seleccione un arma entre espada, espadon, arco, lanza o hacha");
    var arma = Console.ReadLine();

    var armaf = arma.ToUpper().Trim();

    switch (armaf)
    {
        case "ESPADA":
            Console.WriteLine("Elegiste la espada");
            break;
        case "ESPADON":
            Console.WriteLine("Elegiste el espadon");
            break;
        case "ARCO":
            Console.WriteLine("Elegiste el arco");
            break;
        case "LANZA":
            Console.WriteLine("Elegiste la lanza");
            break;
        case "HACHA":
            Console.WriteLine("Elegiste el hacha");
            break;
        default:
            Console.WriteLine("No elegiste un arma valida");
            break;
    }



}


#endregion



