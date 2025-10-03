   # GUIA C SHARP
   
**Imprimir consola*
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

!= (no es igual a)

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
    void NOMBRE () 
    {
        CODIGO 
    }             CREAR BLOQUE
        
    NOMBRE();  LLAMAR BLOQUE
````
**Region**
````csharpc
#region NOMBRE
#endregion
````

**Leer Texto**
````csharpc
string input = Console.ReadLine();
````

**Convertir Texto a dato numerico**
````csharpc
 bool isValid = int.TryParse(input, out int output); // int se puede cambiar por cualquier tipo de dato
 //bool isValid para comprobar si el dato es correcto
````
**Normalizar texto recibido**
````csharpc
string inputnormalizado = input.Trim().ToUpper(); //quitar espacios y convertir a mayusculas
string inputnormalizado = input.Trim().ToLower(); //quitar espacios y convertir a minusculas
//.Trim quita los espacios al inicio y al final de las cadenas
````
**Comprobar Longitud de una cadena**
````csharpc
inputnormalizado.Length = numero de caracteres

````

**Tipo de dato 
````csharpc
var (permite asiganr cualquier tipo de dato)
var "nombre de variable" = "tipo de dato"

null (representa la ausencia de valor)
````

**randomizador 
````csharpc
var random = new Random();
var variable = random.Next(min,max);

````
**estrucutura switch
````csharpc
switch (variable)
{
   case valor:
         // proceso
       break:
   case valor:
         // proceso
       break:
   default:
        // no coincide ningun valor
       break:
}

````

**operador ternario
````csharpc
condicion ? valor si de cumple : condicion si no se cumple ;

string mensage = isLoggedIn ? "welcome back" : "please log in";

````