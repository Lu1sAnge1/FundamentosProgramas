// ejercicios 1 parcial 2

#region Ejercicios
//ejercicio1
//calculadora exp
calculadoraexp();

//ejercicio2
TiradaDeHabilidad();


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



}

#endregion
