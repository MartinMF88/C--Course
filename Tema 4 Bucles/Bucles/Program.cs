// Bucles

// WHILE / MIENTRAS

int i = 1;
Console.Write("WHILE: ");
while(i <= 10)
{
    // cdigo que se ejecuta mientras "True"
    Console.Write(i + " ");
    i++; // i = i+1;
}
Console.WriteLine("\nDespues del while: " + i); // i vale 11 (\n es un salto de linea)

// DO...WHILE - HACER...MIENTRAS
Console.Write("DO...WHILE: ");
i = 5;
do
{
    Console.Write(i+ " ");
    i +=  3 ; // i = i + 3;
} while (i < 10);



// FOR - PARA / POR

Console.Write("\nFOR: ");
for (int j=1; j <= 10; j++) // asignando 1 a la j
{
    Console.Write(j + " ");
}

// FOREACH - PARA/POR CADA
Console.WriteLine("\nFOREACH: ");
var lista = new List<string> { "Pepe", "Juan", "Martin", "Ana" };
foreach (var elemento in lista)
{
    Console.WriteLine(elemento);
}