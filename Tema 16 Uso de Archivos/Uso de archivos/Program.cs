// crear archivos TXT y realizar operaciones
/* Operaciones con archivos:
 - Crear archivo
- Leer -> no modifica el contenido : StreamReder -> elemento.ReadLine()
- Escribir -> StreamWriter -> elemento.WriteLine("Texto")
- Append -> Escribe añadiendo contenido al final
*/


using System.IO;

string texto;

try
{
    StreamReader sr = new StreamReader("miArchivo.txt");
    var linea = sr.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close(); // cerramos el stream asociado al archivo
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}
finally
{
    Console.WriteLine("Final del try-catch-finally.");
}

// Escribir en un archivo .txt

try
{
    StreamWriter sw = new StreamWriter("miArchivo2.txt", true); // con el true seguimos escribiendo mas lineas en el archivo
    sw.WriteLine("Estoy escribiendo mi archivo");
    sw.WriteLine("Otra linea");
    sw.Close();
}
catch(Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}
finally
{
    Console.Write("Final del try-catch-finally.");
}
try
{
    StreamReader sr1 = new StreamReader("miArchivo2.txt");
    var linea = sr1.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr1.ReadLine();
    }
    sr1.Close();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}
