// Sumar los 100 primeros numeros enteros
// Suma = 1 + 2 + ... + 99 + 100

int i = 0;
int suma = 0;
for (i = 0; i<=100; i++)
{
    suma += i;
}
Console.WriteLine(suma); // 5050

// Parte 2 - Expandimos el codigo para que el usuario indique el numero hasta donde sumar

int j = 0;
int resultado = 0;
int limite = 0;
Console.WriteLine("Introduce el limite de la suma:");
limite = Convert.ToInt32(Console.ReadLine());
for (j = 0; j <= limite; j++)
{
    resultado += j;
}
Console.WriteLine($"Resultado: {resultado}");

// Escribir todos los elementos de un array

int[] arr = new int[4]; // asi definimos un array de 3 elementos
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
arr[3] = 4;
Console.WriteLine("For: ");
for (i = 0; i<arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine("\nWhile: ");
i = 0;
while ( i < arr.Length)
{
    Console.Write(arr[i] + " ");
    i++;
}
Console.WriteLine("\nForEach: ");
foreach (var item in arr) // en este caso no es necesario decirle que use el Length
{
    Console.Write(item + " ");
}