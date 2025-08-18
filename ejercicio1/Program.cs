//Ejercicios de clase


{
    //ejercicio jugador
    Console.WriteLine("PLAYER STATS");
    Console.WriteLine("------------");
    Console.WriteLine("HP       100");
    Console.WriteLine("MP       100");
    Console.WriteLine("GOLD   4,500");
    Console.WriteLine("EXP      300");
    Console.WriteLine("------------");
}

{
    //ejercicio jugador2
    Console.Write("PLAYER STATS \n------------\nHP      100 \nMP      100 \nGOLD   4,500 \nEXP      300 \n------------\n");
    Console.Write("PLAYER STATS \n------------\nHP\t100\nMP\t100\nGOLD\t4,500\nEXP\t300\n------------\n");
}

//separacion de ejercicio
Console.WriteLine();Console.WriteLine();Console.WriteLine();Console.WriteLine();Console.WriteLine();

{
    //ejercicio banderas
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("MÉ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("XI");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("CO");
    Console.ResetColor();

    Console.WriteLine();

    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("MÉ");
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("XI");
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Write("CO");
    Console.ResetColor();
}

Console.WriteLine();
Console.WriteLine();

{
    //ejericio banderas2
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("RU");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("SS");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("IA");
    Console.ResetColor();

    Console.WriteLine();

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("ALE");
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("MA");
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.Write("NIA");
    Console.ResetColor();
}

//separacion de ejercicio
Console.WriteLine();Console.WriteLine();

{
    //Console.WriteLine("PLAYER STATS");Console.WriteLine("------------");Console.WriteLine("HP       100");Console.WriteLine("MP       100");Console.WriteLine("GOLD   4,500");Console.WriteLine("EXP      300");Console.WriteLine("------------");Console.Write("PLAYER STATS \n------------\nHP      100 \nMP      100 \nGOLD   4,500 \nEXP      300 \n------------\n");Console.Write("PLAYER STATS \n------------\nHP\t100\nMP\t100\nGOLD\t4,500\nEXP\t300\n------------\n");Console.WriteLine();Console.WriteLine();Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write("MÉ");Console.ForegroundColor = ConsoleColor.White;Console.Write("XI");Console.ForegroundColor = ConsoleColor.DarkRed;Console.Write("CO");Console.ResetColor();Console.WriteLine();Console.BackgroundColor = ConsoleColor.DarkGreen;Console.ForegroundColor = ConsoleColor.Black;Console.Write("MÉ");Console.BackgroundColor = ConsoleColor.White;Console.Write("XI");Console.BackgroundColor = ConsoleColor.DarkRed;Console.Write("CO");Console.ResetColor();Console.WriteLine();Console.WriteLine();Console.ForegroundColor = ConsoleColor.White;Console.Write("RU");Console.ForegroundColor = ConsoleColor.DarkBlue;Console.Write("SS");Console.ForegroundColor = ConsoleColor.DarkRed;Console.Write("IA");Console.ResetColor();Console.WriteLine();Console.BackgroundColor = ConsoleColor.Black;Console.ForegroundColor = ConsoleColor.White;Console.Write("ALE");Console.BackgroundColor = ConsoleColor.DarkRed;Console.ForegroundColor = ConsoleColor.Black;Console.Write("MA");Console.BackgroundColor = ConsoleColor.Yellow;Console.Write("NIA");Console.ResetColor();
}

{
    //ejericicio estadisticas de jugador
    string name        = "Shiki";
    int    level       = 30;
    float  exp         = 19.5F;
    long   nextlevelxp = 232_132_344_525_242_452;
    sbyte  numpocion   = 95;
    string arma        = "greatsword";

    Console.WriteLine(name);
    Console.WriteLine(level);
    Console.WriteLine(exp);
    level = 31;
    exp   = 856.56F;

    Console.WriteLine(name);
    Console.WriteLine(level);
    Console.WriteLine(exp);
    Console.WriteLine(nextlevelxp);
    Console.WriteLine(numpocion);
    Console.WriteLine(arma);

    Console.WriteLine();
}

{
    //ejercicio estadisticas jugador2
    String separador = "---------------------";
    string name      = "Shiki";
    int    hp        = 100;
    int    mana      = 50;
    float  gold      = 350.5f;
    float  exp       = 856f;

    Console.WriteLine("    PLAYER STATS");
    Console.WriteLine(separador);
    Console.WriteLine($"HP:\t {hp}");
    Console.WriteLine($"MANA:\t {mana}");
    Console.WriteLine($"GOLD:\t {gold}");
    Console.WriteLine($"EXP:\t {exp}");
    Console.WriteLine(separador);
}




