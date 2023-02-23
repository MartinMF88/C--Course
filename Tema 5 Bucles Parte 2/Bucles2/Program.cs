//  IF ... ELSE - SI / SINO

Console.WriteLine("Que dia es hoy?:");
string hoy = Console.ReadLine().ToUpper(); // el ToUpper genera que todas las letras ingresadas por el usuario en el terminal se transformen en mayusculas.


/* if (hoy == "Lunes")
{
    Console.WriteLine("Feliz Lunes");
}
else
{
    Console.WriteLine("Hoy no es lunes :(");
}
*/


// SWITCH - CAMBIAR

switch (hoy)
{
    case "LUNES":
        Console.WriteLine("Es lunes!");
        break;
    case "MARTES":
        Console.WriteLine("Es martes!");
        break;
    default:
        Console.WriteLine("Ese dia no lo conozco");
        break;
}

// resto del programa 

// BREAK

if (hoy == "LUNES")
{
    for (int i = 0; i<3; i++)
    {
        Console.WriteLine("Lunes");
        break;
    }
    Console.WriteLine("Despues del break");
}
Console.WriteLine("Despues del if");

// CONTINUE

for (int z = 0; z < 10; z++)
{
    Console.WriteLine(z);
    if (z == 4)
    {
        Console.Write(" z es igual que 4");
        continue;
    }
}