   # GUIA C SHARP
   
**Imprimir consola**
-
- Console.Write - texto seguido
- Console.Writeline - texto con espacio
- Console.Foreground - color de Texto
- Console.Background - color de Fondo
- Console.Resetcolor(); - resetear color
- Console.Color. - consultar color 


 **Tipos de datos**
-
- string - cadena
- int - entero
- Float - flotante (f) al final del numero
- Decimal - decimal
- long - numero muy grande

**declaracion de variable**

````csharp   
string nombre = nombre;
float numero = 1f;
````


**Interpolacion**
````csharp
Console.Write($"Nombre: {nombre}");
Console.Write($"Numero: {numero}");
````

**Secuencia de escape**

    \n - nueva linea
    \t - tabulador
    \" - escribir comilla

Estructura de programa
-

**division de bloques**
````csharp
    void NOMBRE () {}  CREAR BLOQUE
    NOMBRE();  LLAMAR BLOQUE
````
**Region**
````csharpc
#region NOMBRE
#endregion
````



