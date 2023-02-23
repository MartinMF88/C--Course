// STRINGS NULOS Y VACIOS

string str = "hello";
string nullStr = null;
string emptyStr = String.Empty;

string tempStr = str + nullStr;
Console.WriteLine(tempStr);

bool b = (emptyStr == nullStr); // Camel Case -> miVariable, my ArrayStr
Console.WriteLine(b); // false

string newStr = emptyStr + nullStr;
Console.WriteLine(newStr);
Console.WriteLine(emptyStr.Length);
// Console.WriteLine(nullStr.Length);
Console.WriteLine(newStr.Length);

// añadimos valores
nullStr = "a";
Console.WriteLine(nullStr.Length); // 1

emptyStr = "";
emptyStr += nullStr;
Console.WriteLine(emptyStr); // a

// StringBuilder

StringBuilder strBuilder = new StringBuilder("Hola mundo");
Console.WriteLine(strBuilder[0]); // H
Console.WriteLine(strBuilder); // Hola mundo

// Transformar una cadena a número si es posible

float i = 0f;
string s = "21,1";
bool result = float.TryParse(s, out i); // tryparse convierte el string numerico a un its-32 bits (try es intenta, si no se puede hacer va a dar false)
Console.WriteLine(result + ", i: " + i);

// Arrays

int[] arr = new int[2]; // (1,2)

string[] names = new string[2];
names[0] = "John Doe";
names[1] = "John Wick";

foreach (string elemento in names)
{
    Console.WriteLine(elemento);
}

for (int j = 0; j < names.Length-1; j++) // poniendo un -1 despues del length estoy pidiendo todos los elementos menos el ultimo
{
    Console.WriteLine(names[j]);
}

int[] numbers = { 4, 3, 8, 0, 5 };
Array.Sort(numbers);
foreach (int elemento in numbers)
{
    Console.WriteLine(elemento);
}

// MAS TIPOS DE ARRAYS
// ARRAYS EN DOS DIMENSIONES

int[,] miArray2D = new int[2, 2]; // 1 2
                                  // 3 4

miArray2D[0, 0] = 1;
miArray2D[0, 1] = 2;
miArray2D[1, 0] = 3;
miArray2D[1, 1] = 4;

Console.WriteLine("cantidad de elementos: " + miArray2D.Length); // 4
Console.WriteLine("cantidad de filas: " + miArray2D.Rank); // 2

for (int k = 0; k < 2; k++)
{
    for (int l = 0; l < 2; l++)
    {
        Console.Write(miArray2D[k, l] + " ");
    }
    Console.WriteLine("");
}
Console.WriteLine(miArray2D.Length);