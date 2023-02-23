Console.WriteLine("Introduce tu nombre:");
String nombre = Console.ReadLine();

Console.WriteLine("Introduce tu apellido:");
String apellido = Console.ReadLine();

Console.WriteLine("Introduce tu edad");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Sabes programar?");
bool programar = Console.ReadLine();

// Mensaje final

Console.WriteLine("Hola, " + nombre + " " + apellido + ".");
Console.WriteLine("Tienes " + edad + " años,");
Console.WriteLine(" y " + programar + " sabes programar." );
