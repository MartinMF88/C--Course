// Matrices
// m = ((1, 2),
//      (3, 4))

// 1D -> 1 indice o index

// 1. Declarando un array conociendo el numero de elementos
int[] array = new int[2];
array[0] = 1;
array[1] = 2;

// 2. Declarando y fijando los valores del array
int[] array2 = new int[] {1, 2, 3, 4};

// 3. Sintaxis alternativa
int[] array3 = {1, 2, 3};

Console.Write("Array3 = ( ");
for (int i = 0; i < array3.Length; i++)
{
    array3[i] += 1;
}
// array3 -> (2,3,4)
foreach (int el in array3)
{
    Console.Write(el + " ");
}
Console.Write(")\n");

// 2D
// 1. Declarando un array conociendo el numero de elementos pero sin saber los elementos
Console.WriteLine("\n--Matrices--\n");
int size = 5; // -> se suelen usar letras como n, m y n, etc.
int[,] matriz = new int[size,size];

// 2. Declarando una matriz y asignamos los valores que tiene
/*
int rows = 2;
int cols = 3;
int[,] matriz3 = new int[rows,cols];
*/
int[,] matriz2 = { { 1, 2, 3}, { 4, 5, 6} };
Console.WriteLine($"Tamaño matriz 2: {matriz2.Length}");
Console.WriteLine($"Rank matriz 2: {matriz2.Rank}");

// 3. Cuando filas o columnas no son conocidas
int[][] matriz4 = new int[3][];
matriz4[0] = new int[4] {3, 4, 5, 6}; // -> fila 0 asignamos 4 columnas con estos valores
matriz4[1] = new int[4] { 3, 4, 5, 6 };
matriz4[2] = new int[4] { 5, 6, 7, 8 };
Console.WriteLine($"Tamaño: {matriz4.Length}"); // -> 4 = 4 x 1, 4 cols x 1 fila -> (1, 2, 3, 4)

for (int j = 0; j < 3; j++) // -> numero de filas j -> 0,1
{
    for (int k = 0; k < 4; k++) // -> numero de columnas k -> 0, 1, 2
    {
        //matriz[j, k] = j + k;
        if (matriz4[j][k] != null)
        {
            Console.Write(matriz4[j][k] + "\t ");
        }
        else
        {
            matriz4[j][k] = 0;
            Console.Write(matriz4[j][k] + "\t ");
        }
        Console.Write(matriz4[j][k] + "\t ");
    }
    Console.WriteLine();
}

// (0,0) -> arr2D[0,0] -> 0
// (0,1) -> arr2D[0,0] -> 1 
// (1,0) -> arr2D[0,0] -> 1
// (1,1) -> arr2D[0,0] -> 2
