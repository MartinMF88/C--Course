// TUPLAS O TUPLES

(string, double, int) miTupla = ("Cesar", 1.1d, 9);
Console.WriteLine(miTupla);
Console.WriteLine($"Item 1: {miTupla.Item1}, Item 2: {miTupla.Item2}, Item 3: {++miTupla.Item3}");

int miSuma = 0;
for (int i = 0; i<100; i++) { miSuma += i; }
double cociente = 5 / 30d;
(int Suma, double Division) otraTupla = (miSuma, cociente);
Console.WriteLine($"Item 1: {otraTupla.Item1}, Item 2: {otraTupla.Item2}");

var tuplaInt = (1, 2, 3, 4, 5, 6);
Console.WriteLine(tuplaInt.GetType());

Console.WriteLine((int)Estaciones.Verano);
Console.WriteLine((int)CodigosDeError.Desconocido);

enum Estaciones
{
    Verano,
    Primavera,
    Otoño,
    Invierno
}
enum CodigosDeError : ushort
{
    Ninguno = 0,
    Desconocido = 1,
    SinConexión = 100,
    Conexión = 200
}