float f = 3.1411f;
EscribirNumeroReal(f);

void EscribirNumeroReal(float n)
{
    Console.WriteLine(n.ToString("#.###")); // # se usa para indicar la cantidad de decimales del float
}

 void SumaDeNumerosReales(float a, float b)
{
    float resultado = a + b;
    Console.WriteLine(resultado.ToString("#.#"));
}

// RECURSIVIDAD

/*
* Factorial -> !
* 1! = 1
* 2! = 2 * 1
* 3! = 3 * 2 * 1
*/

Console.WriteLine(CalcularFactorial(5));


long CalcularFactorial(int n)
{
    if (n == 1)
    {
        return 1; // cuando n es 1, se devuelve 1 y se termina la recursividad
    }
    return n * CalcularFactorial(n - 1);
}