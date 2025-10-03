
// ejercicios 2 segundo parcial "if"

#region ejercicios
//ejercicio 1
//EstadoVida();

//ejercicio 2
//VidaColor();

//ejercicio 3
//CargaJugador();

//ejercicio 4
//ClasificacionAtaque();

//ejercicio 5
//RecompensaMision();

//ejercicio 6
//RarezaObjeto();

//ejercicio 7
//Pociones();

//ejercicio 8
//BonoEstado();

#endregion



#region soluciones

//ejercicio 1
void EstadoVida() {
    Console.WriteLine("Ingresa tu vida actual entre 0 y 10");
    string vida = Console.ReadLine();

    bool IsValid =  int.TryParse(vida, out int vidav);

    if (IsValid && vidav <=10 && vidav >=0)
    {
        if (vidav == 0)
        {
            Console.WriteLine("[----------]");
        }
        else if (vidav == 1)
        {
            Console.WriteLine("[|---------]");
        }
        else if (vidav == 2)
        {
            Console.WriteLine("[||--------]");
        }
        else if (vidav == 3)
        {
            Console.WriteLine("[|||-------]");
        }
        else if (vidav == 4)
        {
            Console.WriteLine("[||||------]");
        }
        else if (vidav == 5)
        {
            Console.WriteLine("[|||||-----]");
        }
        else if (vidav == 6)
        {
            Console.WriteLine("[||||||----]");
        }
        else if (vidav == 7)
        {
            Console.WriteLine("[|||||||---]");
        }
        else if (vidav == 8)
        {
            Console.WriteLine("[||||||||--]");
        }
        else if (vidav == 9)
        {
            Console.WriteLine("[|||||||||-]");
        }
        else
        {
            Console.WriteLine("[||||||||||]");
        }
    }
    else
    {
        Console.WriteLine("No ingresaste un valor valido");
    }
}

//ejercicio 2
void VidaColor() {

    Console.WriteLine("Ingresa tu vida actual entre 0 y 100");
    string vida = Console.ReadLine();

    bool IsValid =  int.TryParse(vida, out int vidac);

    var vidav = vidac/10;

    if (IsValid && vidav <= 10 && vidav >= 0)
    {

        if (vidac == 100)
        {
        Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (vidac < 100 && vidac >= 75)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (vidac < 75 && vidac >= 50)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (vidac < 50 && vidac >= 25)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else if (vidac < 25 && vidac >= 10)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else if (vidac < 10  && vidac >= 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        else  if (vidac == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }


        if (vidav == 0)
        {
            Console.WriteLine("[----------]");
        }
        else if (vidav == 1)
        {
            Console.WriteLine("[|---------]");
        }
        else if (vidav == 2)
        {
            Console.WriteLine("[||--------]");
        }
        else if (vidav == 3)
        {
            Console.WriteLine("[|||-------]");
        }
        else if (vidav == 4)
        {
            Console.WriteLine("[||||------]");
        }
        else if (vidav == 5)
        {
            Console.WriteLine("[|||||-----]");
        }
        else if (vidav == 6)
        {
            Console.WriteLine("[||||||----]");
        }
        else if (vidav == 7)
        {
            Console.WriteLine("[|||||||---]");
        }
        else if (vidav == 8)
        {
            Console.WriteLine("[||||||||--]");
        }
        else if (vidav == 9)
        {
            Console.WriteLine("[|||||||||-]");
        }
        else
        {
            Console.WriteLine("[||||||||||]");
        }


    }
    else
    {
        Console.WriteLine("No ingresaste un valor valido");
    }

}

//ejercicio 3
void CargaJugador() {
    Console.WriteLine("ingresa el limite de peso ligero");
    var pesol = Console.ReadLine();
    Console.WriteLine("ingresa el limite de peso medio");
    var pesom = Console.ReadLine();
    Console.WriteLine("ingresa el limite de peso pessado");
    var pesop = Console.ReadLine();
    Console.WriteLine("ingresa tu peso actual");
    var peso =  Console.ReadLine();

    var isValid = int.TryParse(pesol, out var pesolf);
    var isValid2 = int.TryParse(pesom, out var pesomf);
    var isValid3 = int.TryParse(pesop, out var pesopf);
    var isValid4 = int.TryParse(peso, out var pesof);

    if (isValid && isValid2 && isValid3 && isValid4)
    {
        if (pesolf < pesomf && pesomf < pesopf)
        {

            if (pesof > 0 && pesof <= pesolf)
            {
            Console.WriteLine("El peso cargado es peso ligero");
            }
            else if (pesof > pesolf && pesof <= pesomf)
            {
            Console.WriteLine("El peso cargado es peso medio");
            }
            else if (pesof > pesomf && pesof <= pesopf)
            {
            Console.WriteLine("El peso cargado es peso pesado");
            }
            else
            {
            Console.WriteLine("El peso ingresado no esta en el rango de peso");
            }

        }
        else
        {
            Console.WriteLine("Los rangos del peso no estan correctos");
        }

    }
    else
    {
        Console.WriteLine("No ingresaste un valor valido");
    }
}

//ejercicio 4
void ClasificacionAtaque() {

    Console.WriteLine("ingresa valor de daño");
    var dano = Console.ReadLine();
    Console.WriteLine("ingresa valor de defensa");
    var defensa = Console.ReadLine();

    var isValid  = int.TryParse(dano, out var danof);
    var isValid2 = int.TryParse(defensa, out var defensaf);

    if (isValid && isValid2)
    {

        if (danof > defensaf * 2)
        {
            Console.WriteLine("Hiciste un golpe critico");
        }

        else if (danof > defensaf)
        {
            Console.WriteLine("Hiciste un golpe fuerte");
        }

        else if (danof == defensaf)
        {
            Console.WriteLine("Hiciste un golpe normal");
        }
        else
        {
            Console.WriteLine("Hiciste un golpe debil");
        }

    }
    else
    {
        Console.WriteLine("No ingresaste un valor valido");
    }


}

//ejercicio 5
void RecompensaMision() {
    Console.WriteLine("Recompensa de mision:");

    var random = new Random();
    var xp    = random.Next(0,1100);

    Console.WriteLine($"{xp}");

    if (xp > 1000)
    {
        Console.WriteLine("Tu recompensa es Legendaria");
    }
    else if (xp <= 1000 && xp >= 500)
    {
        Console.WriteLine("Tu recompensa es Epica");
    }
    else if (xp >100 && xp < 500)
    {
        Console.WriteLine("Tu recompensa es Rara");
    }
    else if (xp <=100)
    {
        Console.WriteLine("Tu recompensa es Común");
    }
}

//ejercicio 6
void RarezaObjeto() {

    Console.WriteLine("Ingresa el nombre de tu objeto");
    var nombre = Console.ReadLine();

    var random =  new Random();
    var rareza = random.Next(1,9);

    if (rareza == 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"{nombre} Muy Comun");
    }
    else if (rareza == 2)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{nombre} Comun");
    }
    else if (rareza == 3)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{nombre} Raro");
    }
    else if (rareza == 4)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nombre} Rarisimo");
    }
    else if (rareza == 5)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{nombre} Epico");
    }
    else if (rareza == 6)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{nombre} Legendario");
    }
    else if (rareza == 7)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{nombre} Mitico");
    }
    else if (rareza == 8)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"{nombre} Cosmico");
    }

}

//ejercicio 7
void Pociones() {

    Console.WriteLine("para crear pocion de mana necesitas:");
    Console.WriteLine("5 flor de luna, 10 agua y 3 ruby");
    Console.WriteLine("para crear pocion de vida necesitas:");
    Console.WriteLine("3 flor de luna, 5 de agua y 8 ruby");

    Console.WriteLine("ingresa cantidad de flor de luna");
    var flor = Console.ReadLine();
    Console.WriteLine("ingresa cantidad de agua");
    var agua = Console.ReadLine();
    Console.WriteLine("ingresa cantidad de ruby");
    var ruby = Console.ReadLine();
    Console.WriteLine("ingresa la pocion que quieres crear");
    var pocion = Console.ReadLine();

    var isValid = int.TryParse(flor, out var florf);
    var isValid2 = int.TryParse(agua, out var aguaf);
    var isValid3 = int.TryParse(ruby, out var rubyf);

    var pocionf = pocion.Trim().ToUpper();

    if (isValid && isValid2 && isValid3 && florf > 0 && aguaf > 0 && rubyf > 0 )
    {
        if (pocionf == "MANA")
        {
            var cant1 = florf / 5;
            var cant2 = aguaf / 10;
            var cant3 = rubyf / 3;

            if (cant1 <= cant2 && cant2 <= cant3)
            {
                var sobr  = florf - (cant1 * 5);
                var sobr2 = aguaf - (cant1 * 10);
                var sobr3 = rubyf - (cant1 * 3);

                Console.WriteLine($"Puedes hacer {cant1} pociones de mana");
                Console.WriteLine($"Te sobran {sobr} flor de luna, {sobr2} agua y {sobr3} ruby");
            }
            else if (cant2 <= cant1 && cant2 <= cant3)
            {
                var sobr  = florf - (cant2 * 5);
                var sobr2 = aguaf - (cant2 * 10);
                var sobr3 = rubyf - (cant2 * 3);

                Console.WriteLine($"Puedes hacer {cant2} pociones de mana");
                Console.WriteLine($"Te sobran {sobr} flor de luna, {sobr2} agua y {sobr3} ruby");
            }
            else if (cant3 <= cant1 && cant3 <= cant2)
            {
                var sobr  = florf - (cant3 * 5);
                var sobr2 = aguaf - (cant3 * 10);
                var sobr3 = rubyf - (cant3 * 3);

                Console.WriteLine($"Puedes hacer {cant3} pociones de mana");
                Console.WriteLine($"Te sobran {sobr} flor de luna, {sobr2} agua y {sobr3} ruby");
            }
        }
        else if (pocionf == "VIDA")
        {
            var cant1 = florf / 3;
            var cant2 = aguaf / 5;
            var cant3 = rubyf / 8;


            if (cant1 >= cant2 && cant2 >= cant3)
            {

                var sobr  = florf - (cant1 * 3);
                var sobr2 = aguaf - (cant1 * 5);
                var sobr3 = rubyf - (cant1 * 8);

                Console.WriteLine($"Puedes hacer {cant1} pociones de vida");
                Console.WriteLine($"Te sobran {sobr} flor de luna, {sobr2} agua y {sobr3} ruby");
            }
            else if (cant2 >= cant1 && cant2 >= cant3)
            {
                var sobr  = florf - (cant2 * 3);
                var sobr2 = aguaf - (cant2 * 5);
                var sobr3 = rubyf - (cant2 * 8);

                Console.WriteLine($"Puedes hacer {cant2} pociones de vida");
                Console.WriteLine($"Te sobran {sobr} flor de luna, {sobr2} agua y {sobr3} ruby");
            }
            else if (cant3 >= cant1 && cant3 >= cant2)
            {
                var sobr  = florf - (cant3 * 3);
                var sobr2 = aguaf - (cant3 * 5);
                var sobr3 = rubyf - (cant3 * 8);

                Console.WriteLine($"Puedes hacer {cant3} pociones de vida");
                Console.WriteLine($"Te sobran {sobr} flor de luna, {sobr2} agua y {sobr3} ruby");
            }
        }
        else
        {
            Console.WriteLine("No se ingreso una pocion valida");
        }
    }
    else
    {
        Console.WriteLine("No ingresaste un valor valido");
    }

}

//ejercicio 8
void BonoEstado() {

    Console.WriteLine("Quemadura aplica 150% daño");
    Console.WriteLine("frosbite aplica 200% el daño");
    Console.WriteLine("petrificado aplica 175% el daño");

    Console.WriteLine("ingresa el daño base");
    var daño = Console.ReadLine();
    Console.WriteLine("ingrese el estado alterado del enemigo");
    var estado = Console.ReadLine();

    var isValid = int.TryParse(daño, out var dañof);
    var estadof = estado.Trim().ToUpper();


    if (isValid)
    {
        if (estadof == "QUEMADURA")
        {
            var dañot = dañof * 1.5f;

            Console.WriteLine($"Tu daño total es {dañot} por quemadura");
        }
        else if (estadof == "FROSBITE")
        {
            var dañot = dañof * 2f;

            Console.WriteLine($"Tu daño total es {dañot} por frosbite");
        }
        else if (estadof == "PETRIFICADO")
        {
            var dañot = dañof * 1.75f;

            Console.WriteLine($"Tu daño total es {dañot} por petrificacion");
        }
        else
        {
            Console.WriteLine("No ingresaste un estado alterado correcto");
        }
    }
    else
    {
        Console.WriteLine("No ingresaste un valor valido");
    }

}

#endregion
