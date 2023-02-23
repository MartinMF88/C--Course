// Depuración o Debugging, Debug
// bug -> "error", "typo", "resultado incorrecto", etc.

using System.Diagnostics;

Console.WriteLine(" Escribe tu mensaje:");
var msg = Console.ReadLine();
Console.WriteLine($"He recibido el mensaje: {msg}");
int resultado = 0;
Stopwatch sw = new Stopwatch();
sw.Start();
for (int i = 0; i < 10; i++)
{
    resultado = i * i + 1;
    // Console.WriteLine(resultado);
    // Operacion que queremos controlar
}
sw.Stop();
var tiempo = sw.Elapsed;
Console.ReadLine();