int n = 2;
int[,] a = { { 1, 2 }, { 3, 4 } };
int[,] b = { { -1, 0}, {0, -1 } };
int[,] c = { { 0, 0 }, { 0, 0 } };
Console.WriteLine(" Matriz c: ");
for (int j = 0; j < n; j++)
{
    for (int k = 0; k < n; k++)
    {
        c[j, k] = a[j, k] + b[j, k];
        Console.Write(c[j, k] + "\t");
    }
    Console.WriteLine();
}