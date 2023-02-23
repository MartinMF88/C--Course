Console.WriteLine("Introduce tu nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("Introduce tu email:");
string mail = Console.ReadLine();

Console.WriteLine("Tienes cupon de descuento? Ingresa True para si, o False para no.");
bool cupon = Convert.ToBoolean(Console.ReadLine());

int precioproducto = 30;
double descuento25 = 0.25 ;

if (cupon)
{
    Console.WriteLine("El precio es: $" + precioproducto * (1-descuento25));
} else
{
    Console.WriteLine("El precio es: $" + precioproducto);
}