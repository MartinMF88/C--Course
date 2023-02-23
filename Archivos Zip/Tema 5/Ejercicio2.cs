Console.WriteLine("Selecciona un lenguaje usando un numero del 1 al 4:");
Console.WriteLine("1 - C#");
Console.WriteLine("2 - Java");
Console.WriteLine("3 - C++");
Console.WriteLine("4 - Rust");
string lenguajes = Console.ReadLine().ToUpper();

switch (lenguajes)
{
    case "1":
        Console.WriteLine("Has seleccionado C#" + "\n Hola, mundo");
        break;
    case "2":
        Console.WriteLine("Has seleccionado Java");
        break;
    case "3":
        Console.WriteLine("Has seleccionado C++");
        break;
    case "4":
        Console.WriteLine("Has seleccionado Rust");
        break;
}

