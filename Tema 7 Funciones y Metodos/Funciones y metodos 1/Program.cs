// int resultado = CalcularCuadrado(2); // 4
// Console.WriteLine(resultado); // 4


/* Main */
CalcularAprobado(1);
CalcularAprobado(5);
CalcularAprobado(9);

// Scope, Contexto
int i = 0;
Console.WriteLine("i desde Main: " + i);
int a = EntendiendoScope(3, i);
Console.WriteLine(a); // a
/* End of main */

/* Definiciones de las funciones */
int EntendiendoScope(int n, int a)
{
    // Console.WriteLine(n * n);
    // int i = 1; En este caso se comenta el int=i porque el i ya esta declarado al inicio
    a = a + 1;
    Console.WriteLine("a desde fun: " + a);
    return a; // int
    // codigo
}

void CalcularAprobado(int a)
{
    if (a < 5)
    {
        Console.WriteLine("Has suspendido :( ");
    }
    else if (a == 5)
    {
        Console.WriteLine("Aprobado con aceptable ");
    }
    else
    {
        Console.WriteLine("Aprobado ");
    }
}

/* End definciones de funciones */

// FUNCIONES ANONIMAS (input-parametrers) => expression
int[] numbers = { 2, 3, 4, 5 };
var squaredNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squaredNumbers));
