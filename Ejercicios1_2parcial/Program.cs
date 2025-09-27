// ejercicios 1 parcial 2

#region Ejercicios
//ejercicio1
//calculadora exp
//calculadoraexp();

//ejercicio2
//Tirada de habilidad
//TiradaDeHabilidad();

//Ejercicio3
//Validacion de mensaje de mision
//ValidacionMensaje();

//ejercicio 4
//ArteConsola();
#endregion

#region  Soluciones

//ejercicio 1
//calculadora de experiencia
void calculadoraexp() {
    Console.WriteLine("Ingresa cantidad de experiencia");
    string exp = Console.ReadLine();

    Console.WriteLine("Ingresa cantidad de experiencia necesaria para subir de nivel");
    string subir = Console.ReadLine();

    bool isvalid = int.TryParse(exp, out int expf);
    bool isvalid2 = int.TryParse(subir, out int subirf);

    if (isvalid && isvalid2)
    {
        int nivel = subirf - expf;

        Console.WriteLine($"La cantidad de expericencia faltante es:  {nivel} xp");
    }

    else
    {
        Console.WriteLine("no ingrsaste numeros validos");
    }

}

//ejercicio2
//Tirada de habilidad

void TiradaDeHabilidad() {
    Console.WriteLine("Ingrese su destreza");
    string dest = Console.ReadLine();

    Console.WriteLine("Ingrese su bono de equipo");
    string bono = Console.ReadLine();

    const int dificul = 30;

    bool isvalid = int.TryParse(dest, out int destf);
    bool isvalid2 = int.TryParse(bono, out int bonof);

    if (isvalid && isvalid2)
    {
        int sigilo = (destf * 2) + bonof;

        if (sigilo >= dificul)
        {
            Console.WriteLine("Exito");
        }
        else
        {
            Console.WriteLine("Fracaso");
        }
    }

    else
    {
        Console.WriteLine("no ingrsaste numeros validos");
    }

}

//ejercicio 3
//validacion de mensaje objetivo
void ValidacionMensaje() {

    Console.WriteLine("Escriba la descripcion de una mision, tiene que iniciar con la palabra (objetivo)");
    string frase = Console.ReadLine();

    string frasef = frase.Trim();

    if (frasef.StartsWith("Objetivo:") && frasef.Length > 0 && frasef.Length <60)
    {
        Console.WriteLine("TRUE");
    }
    else
    {
        Console.WriteLine("FALSE");
    }


}

//ejercicio 4
//arte en consola
void ArteConsola() {

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("       /\\_/\\       ");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("      ( ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("o");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(".");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("o");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine(" )      ");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("       ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(">");
    Console.Write(" ^ ");
    Console.WriteLine("<");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("     (       )   ///  ");
    Console.WriteLine("    ( '_' '_' )//    ");
    Console.WriteLine("      '--'--'      ");

    Console.ResetColor();

}


#endregion
