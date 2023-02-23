// USOS DE FECHAS Y HORARIOS

/* var ahora = DateTime.Now;
Console.WriteLine(ahora);
var hora = ahora.ToShortTimeString();
Console.WriteLine(hora);
var fecha = ahora.ToShortDateString();
Console.WriteLine(fecha);

TimeOnly soloHora = new TimeOnly(15, 0);
Console.WriteLine(soloHora);
DateOnly soloFecha = new DateOnly(2022, 11, 8);
Console.WriteLine(soloFecha.ToLongDateString());
*/


// Usos de interfaces

var persona = new Persona();
// persona.PreguntarNombre();
Console.WriteLine(persona.Nombre);
public class Persona : IPersonas
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public Persona()
    {
        PreguntarDatos();
        EscribirDatos();
    }
    public void PreguntarDatos()
    {
        Console.WriteLine("Cual es tu nombre?");
        var nombre = Console.ReadLine();
        if (nombre == null)
        {
            Console.WriteLine("No introdujo nombre");
        }
        else
        {
            Nombre = nombre;
        }
        Console.WriteLine("Cual es tu fecha de nacimiento (aaaa/mm/dd)?");
        var fecha = Console.ReadLine();
        FechaNacimiento = DateOnly.Parse(fecha);
    }
    public void EscribirDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}, Fecha de Nacimiento: {FechaNacimiento}");
    }
}
    public interface IPersonas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool EnActivo { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public void PreguntarDatos();
        public void EscribirDatos();
    }