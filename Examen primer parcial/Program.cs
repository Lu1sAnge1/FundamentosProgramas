//examen primer parcial

#region Ejercicios
//ejercicio 2
//antidoto();
//ejercicio3
//creaciondepersonaje();
//ejercicio4
//temporizador();
//ejercicio5
//conversionDeMonedas();
//ejercicio8
//sistemaContraseña();
//ejercicio 1
//calculadoraderaciones();
//ejercicio 8
//sistemadeencantamiento();
//ejercicio 9
//ConversorDeRecursos();
//ejercicio 11
//MarioWorld();
//ejercicio 12
//MarioWorldAcolor();


#endregion



#region soluiones
//ejercicio 2
void antidoto() {

    Console.WriteLine("Te dañaron con un veneno que hace 127 puntos de daño, el antidoto cura 30 puntos por dosis");
    Console.WriteLine("ingresa dosis de antidoto");
    string antidoto = Console.ReadLine();

    bool isvalid = int.TryParse(antidoto, out int antidotov);

    if (isvalid)
    {
        int cura  = antidotov * 30;
        int curaf = 127 - cura;

        if (curaf <= 0)
        {
            Console.WriteLine("Te has curado el veneno");
        }
        else
        {
            Console.WriteLine($"Te quedan {curaf} puntos de veneno");
        }


    }
    else
    {
        Console.WriteLine("El valor de antidoto es invalido");
    }


}
//ejercicio3
void creaciondepersonaje(){

    Console.WriteLine("Creacion de personaje");
    Console.WriteLine("Asigna los puntos de atributos entre 1 y 10 y la suma no debe pasar 20 puntos");
    Console.WriteLine("asigna los puntos de fuerza");
    string fuerza = Console.ReadLine();
    Console.WriteLine("asigna los puntos magia");
    string magia = Console.ReadLine();
    Console.WriteLine("asigna los puntos de velocidad");
    string velocidad = Console.ReadLine();

    bool validf = int.TryParse(fuerza, out int fuerzav);
    bool validv = int.TryParse(velocidad, out int velocidadv);
    bool validm = int.TryParse(magia , out int magiav);

    int sumavalor = fuerzav + velocidadv + magiav;


    if (validf && validv && validm)
    {
        if (fuerzav <=10 && velocidadv <=10 && magiav <=10)
        {
            if (sumavalor <= 20)
            {
                Console.WriteLine("Creacion de personaje valida");
            }

            else
            {
                Console.WriteLine("Creacion de personaje invalido");
            }
        }

        else
        {
            Console.WriteLine("creacion de personaje invalido");
        }
    }
    else
    {
        Console.WriteLine("creacion de personaje invalido");
    }




}
//ejercicio5
void temporizador() {

    Console.WriteLine("Ingrese los segundos que tarda en recargarse su habilidad");
    string segundos = Console.ReadLine();

    bool valids = int.TryParse(segundos, out int segundosv);

    if (valids)
    {

        int segund  = segundosv % 60;
        int converm = segundosv / 60;
        int minutos = converm % 60;
        int converh = converm / 60;

        Console.WriteLine($"el tiempo de recarga de la habilidad es: {converh} horas, {minutos} minutos, {segund} segundos");
    }
    else
    {
        Console.WriteLine("los segundos ingresados no son validos");
    }

}
//ejercico5
void conversionDeMonedas() {

    Console.WriteLine("El reino usa monedas de oro, plata y bronce");
    Console.WriteLine("1 moneda de oro on 10 de plata y 1 moneda de plata son 100 de bronce  ");
    Console.WriteLine("ingrese cantidad de monedas de bronce");
    string bronce = Console.ReadLine();
    Console.WriteLine("ingrese cantidad de monedas de plata");
    string plata = Console.ReadLine();
    Console.WriteLine("ingrese cantidad de moneda de oro");
    string oro = Console.ReadLine();

    bool validb = int.TryParse(bronce, out int broncev);
    bool validp = int.TryParse(plata, out int platav);
    bool valido = int.TryParse(oro, out int orov);

    if (validb && validp && valido)
    {
        if (broncev > 0 && platav > 0 && orov > 0)
        {
            int converbronce = broncev % 10;
            int converplata  = broncev / 10;
            int converplataf = converplata % 10;
            int converoro    = platav / 10;
            int converorof   = converoro + orov;

            Console.WriteLine($"La cantidad de monesas que tienes son: {converorof} de oro, {converplataf} de plata y {converbronce} de bronce");

        }
        else
        {
            Console.WriteLine("Los valores de las monedas no son validas");
        }
    }

    else
    {
        Console.WriteLine("Los valores de las monedas no son validas");
    }


}
//ejercicio10
void sistemaContraseña() {

    Console.WriteLine("ingrese su rango: Soldado, Capitan, Comandante");
    string rango = Console.ReadLine();

    Console.WriteLine("ingrese contraseña: Alpha, Beta, Gamma");
    string contraseña = Console.ReadLine();

    string rangonorma = rango.Trim().ToUpper();
    string contraseñanorma = contraseña.Trim().ToUpper();

    if (rangonorma == "SOLDADO" && contraseñanorma == "ALPHA")
    {
        Console.WriteLine("Acceso Autorizado");
    }
    else if (rangonorma == "CAPITAN" && contraseñanorma == "BETA")
    {
        Console.WriteLine("Acceso Autorizado");
    }
    else if (rangonorma == "COMANDANTE" && contraseñanorma == "GAMMA")
    {
        Console.WriteLine("Acceso Autorizado");
    }
    else
    {
        Console.WriteLine("Acceso Denegado");
    }

}
//ejercicio 1
void calculadoraderaciones() {
    Console.WriteLine("¿cuantos dias planeas viajar?");
    string dias = Console.ReadLine();
    Console.WriteLine("¿planeas convatir?");
    string convatir = Console.ReadLine();

    string convatirnorma = convatir.Trim().ToUpper();


    bool isValid = int.TryParse(dias, out int diasv);
    if (isValid)
    {
        int comida = diasv * 3;
        int agua   = diasv * 2;

        if (convatirnorma == "SI")
        {
            int posiones = (diasv / 2);
            Console.WriteLine($"ocupaste {comida} de comida");
            Console.WriteLine($"ocupaste {agua} de agua");
            Console.WriteLine($"ocupaste {posiones} de posiones");
        }
        else
        {
          Console.WriteLine($"ocupaste {comida} de comida");
          Console.WriteLine($"ocupaste {agua} de agua");
        }

    }
}
//ejercicio 8
void sistemadeencantamiento() {
    Console.WriteLine("¿cual es el daño base de tu arma?");
    string daño   = Console.ReadLine();
    bool   validd = float.TryParse(daño, out float dañov);

    if (validd)
    {


    Console.WriteLine("¿que encantamiento deseas implementar fuego,hielo o electrico?");
    string encantamiento  = Console.ReadLine();
    string encantamienton = encantamiento.Trim().ToUpper();


   if (encantamienton == "FUEGO")
   {
       float dañototal = dañov * 1.5f;
       Console.WriteLine($"tu daño total de fuego es {dañototal}");
   }
   else if (encantamienton == "HIELO")
   {
       float dañototal = dañov + 18f;
       Console.WriteLine($"tu daño total de hielo es {dañototal} ");
   }
   else if (encantamienton == "ELECTRICO")
   {
       float dañototal = dañov * 1.1f + 10f;
       Console.WriteLine($"tu daño total de electrico es {dañototal}");
   }
   else
   {
      Console.WriteLine($"los datos ingresados son incorrectos");
   }
   }
else
{
    Console.WriteLine($"los datos del daño son incorrectos");
}

}
//ejercicio 9
void ConversorDeRecursos()
{

Console.WriteLine("\nConversor de hierro a lingotes");
Console.WriteLine("\n¿Cuánto hierro tienes?");

String Hierro = Console.ReadLine();

bool validH = int.TryParse(Hierro, out int hierroV);

if (validH)
{
    if (hierroV >= 5)
    {
        int Lingote = hierroV / 5;
        int Sobra = hierroV % 5;
        Console.WriteLine($"Tienes:{Lingote} lingotes y te sobran: {Sobra} de hierro");
    }
    else
    {
        Console.WriteLine("No tienes suficiente hierro.");
    }
}
else
{
    Console.WriteLine("No ingresaste un número válido.");
}
}
//ejercicio 11
void MarioWorld()
{

    Console.Write("MARIO X 02");
    Console.Write("\tWORLD");
    Console.WriteLine("\t      TIME");

    Console.Write("      0  0  X  00 1-1");
    Console.WriteLine("\t       396");

    Console.WriteLine(" ::::::::::::::::::::::::::::::::::");
    Console.WriteLine(" ==================================");

    Console.WriteLine("\t         ./=~./=\\.");
    Console.WriteLine("\t        \\.;\\~_/");
    Console.WriteLine("\n");

    Console.WriteLine("                  / \\ ");
    Console.WriteLine("                ./   \\.");
    Console.WriteLine("           [?]./      \\.");
    Console.WriteLine("    / \\   ./           \\.");
    Console.WriteLine("  _/   \\./           ^.^ \\");
    Console.WriteLine("    [_] ,'.    ^|^   ^|^  \\");
    Console.WriteLine("   /[_];:      ^|^    |    \\");
    Console.WriteLine("===================================");
    Console.WriteLine(":::::::::::::::::::::::::::::::::::");
    Console.WriteLine("===================================");

}
//ejercicio 12
void MarioWorldAcolor()
{

    Console.ForegroundColor = ConsoleColor.White;
        Console.Write("MARIO X 02");
        Console.Write("\tWORLD");
        Console.WriteLine("\t      TIME");

        Console.Write("      0  0  X  00 1-1");
        Console.WriteLine("\t       396");
    Console.ResetColor();

    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(" ::::::::::::::::::::::::::::::::::");
        Console.WriteLine(" ==================================");

    Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t         ./=~./=\\.         ");
        Console.WriteLine("\t        \\._;\\_~_/          ");
        Console.WriteLine("                                   ");

        Console.WriteLine("                  / \\              ");
        Console.WriteLine("                ./   \\.            ");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("           [");
    Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("?");
    Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("]");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("./      \\.           ");
    Console.ForegroundColor = ConsoleColor.White;
        Console.Write("    / \\    ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("./           \\.         ");
        Console.WriteLine("  _/   \\./           ^.^ \\         ");
        Console.Write(" [___] ,'.     ^");
    Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("|");
    Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("^   ^");
    Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("|");
    Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("^  \\        ");
        Console.Write("/[___]*;:*     ^");
    Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("|");
    Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("^");
    Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("    |");
    Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("    \\       ");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("===================================");
        Console.WriteLine(":::::::::::::::::::::::::::::::::::");
        Console.WriteLine("===================================");

    Console.ResetColor();
}



#endregion
