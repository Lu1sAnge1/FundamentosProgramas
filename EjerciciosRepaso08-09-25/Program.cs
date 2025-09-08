//ejercicios de repaso

#region PROBLEMAS
//ejercicio 1
Alquimia();
//ejercicio 2
Gremio();

#endregion



#region SOLUCIONES

//ejercicio 1
//simulador de alquimia
void Alquimia() {
    Console.WriteLine("Ingrese la cantidad de plomo");
    string plomosrt = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad de cobre");
    string cobresrt = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad de hierro");
    string hierrostr = Console.ReadLine();

    bool plomoesnumero = int.TryParse(plomosrt, out int plomo);
    bool cobresnumero = int.TryParse(cobresrt, out int cobre);
    bool hierroesnumero = int.TryParse(hierrostr, out int hierro);

    Console.WriteLine("Ingrese la llave para la transmutacion");
    string llave = Console.ReadLine();

    string llavenormalizada = llave.Trim().ToUpper();

    if (llavenormalizada != "MAGIA")
    {
        Console.WriteLine("No se ingreso una llave correcta");
    }
    else if (cobresnumero == false || hierroesnumero == false || plomoesnumero == false)
    {
       Console.WriteLine("Los valores de los materiales son erroneos");
    }
    else
    {
        float plata = (plomo + cobre) / 2F;
        float oro   = (hierro + (plata / 2F)) / 3F;

        if (llavenormalizada.Length >= 5)
        {
            plata = plata * 1.5F;
            oro = oro * 1.5F;
        }

        Console.WriteLine("ingredientes:");
        Console.WriteLine($"plomo:\t{plomo}");
        Console.WriteLine($"cobre:\t{cobre}");
        Console.WriteLine($"hierro:\t{hierro}");
        Console.WriteLine("Resultados");
        Console.WriteLine($"plata:\t{plata}");
        Console.WriteLine($"oro:\t{oro}");

    }


}

//ejercicio 2
//calcular cuotas mensuales de los miembros del gremio
void Gremio() {

    const int    cuotabase = 150;
    const float  cuotain   = cuotabase - (cuotabase * 0.1F);
    const float  cuotmiem  = cuotabase - (cuotabase * .25F);
    const float  cuotavete = cuotabase - (cuotabase * .5F);
    const string Iniciado;
    const string Miembro;
    const string Veterano;
    const int    longitudmax  = 4;
    const int    penalizacion = 5;
    float        cuotafinal;

    Console.WriteLine("ingrese el nombre del mienbro del gremio");
    string nombre = Console.ReadLine();

    Console.WriteLine("ingrese el rango del miembro del gremio");
    string rango = Console.ReadLine();

    string nombrenorm = nombre.Trim().ToUpper();

    if (nombrenorm != "INICIADO" || nombrenorm != "MIEMBRO" || nombrenorm != "VETERANO")
    {
        Console.WriteLine("No se ingreso un rango del gremio correcto");
    }
    else
    {
        if (nombrenorm == "INICIADO")
        {

            if (nombrenorm.Length >= longitudmax)
            {
                cuotafinal = cuotain - penalizacion;
                Console.WriteLine($"");
            }
        }
    }
}


#endregion
