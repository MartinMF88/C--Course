Console.Write("Ingrese un numero: ");
int numero = int.Parse(Console.ReadLine());
if (numero == 0)
{
    Console.Write("El numero " + numero + " es neutro");
}
else if (numero <= 0)
{
    Console.Write("El numero " + numero + " es negativo");
}
else if (numero >= 0)
{
    Console.Write("El numero " + numero + " es positivo");
}