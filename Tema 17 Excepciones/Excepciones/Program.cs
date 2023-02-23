// Excepciones

Console.WriteLine($"1 entre 2: {DivisionSegura(1, 2)}"); // comprobamos si funciona
try
{
    Console.WriteLine($"1 entre 0: {DivisionSegura(1, 0)}"); // Nan : no es un numero
}
catch (Exception ex)
{
    Console.WriteLine($"Error. Ha ocurrido esto: {ex.Message}");
}
Console.WriteLine($"1 entre 3: {DivisionSegura(1, 3)}"); // comprobamos si funciona

int[] arr = new int[3];
arr[0] = 0;
arr[1] = 1;
arr[2] = 2;
try { Console.WriteLine(arr[3]); }
catch (Exception ex) { Console.WriteLine(ex.Message); } // tira el error avisando de que el indice es mayor al numero de posiciones que tiene el array
finally { Console.WriteLine("Es correcto el valor que aparece?"); { Console.ReadLine(); }
    }

Console.WriteLine("Fin del programa");

static double DivisionSegura(double a, double b)
{
    if (b == 0)
    {

        throw new UsuarioNoEncontradoException();
    }
    return a / b;
}

/* TIPOS
- Exception -> clase base de las excepciones
- IndexOutOfRangeException -> se intento pedir un elemento que no existe en un array
- NullReferenceException -> se pidio un objeto null
                object obj = null;
                obj.ToString();
-  ArgumentException -> clase base para Excepciones relacionadas con argumentos
- ArgumentNullException
              string str = null;
              str.Substring(0, 2);
- ArgumentOutOfRangeException
        string str = "string";
        str.Substring(0, str.Length + 1);
*/