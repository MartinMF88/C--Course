persona alumno = new persona();
Console.WriteLine(persona.experiencia);
alumno.Nombre = "Martin";
alumno.FechaNacimiento = Convert.ToDateTime("08/07/1988");
alumno.registrar();
Console.WriteLine("La edad del alumno " + alumno.Nombre + " es " + alumno.Edad);

// Clase Persona con encapsulamiento mas abierto
/* public class persona{
    // Atributos
    public string nombre;
    public DateTime fechaNacimiento;
    private int edad;
    // Metodos
    public void registrar()
    {
        calcularEdad(fechaNacimiento);
        Console.WriteLine(nombre + " con " + edad + " años de edad, ha sido registrado correctamente");
    }
    private void calcularEdad(DateTime fechaNacimientoPersona)
    {
        DateTime fechaActual = DateTime.Now;
        edad = fechaActual.Year - fechaNacimientoPersona.Year;
    }
   
    }
}
*/

//// Clase Persona con encapsulamiento mas cerrado

public class persona
{
    // Atributos
    public static string experiencia = "C#";
    private string _nombre;
    private DateTime _fechaNacimiento;
    private int _edad;
   
    // Propiedades
   public int Edad
    {
        get // Encapsulacion nivel abierto, por defecto es publico porque la propiedad es publico
        {
            return _edad;
        }
        private set // Encapsulacion nivel cerrado- Privado
        {
            _edad = value;
        }
    }
        public string Nombre
    {
        get
        {
            return _nombre;
        }
        set
        {
            _nombre = value;
        }
    }
    public DateTime FechaNacimiento
    {
        get
        {
            return _fechaNacimiento;
        }
        set
        {
            _fechaNacimiento = value;
        }

    }
    // Metodos
    public void registrar()
    {
        calcularEdad(FechaNacimiento);
        Console.WriteLine(Nombre + " ha sido registrado correctamente");
    }
    private void calcularEdad(DateTime fechaNacimientoPersona)
    {
        DateTime fechaActual = DateTime.Now;
        Edad = fechaActual.Year - fechaNacimientoPersona.Year;
    }
    }