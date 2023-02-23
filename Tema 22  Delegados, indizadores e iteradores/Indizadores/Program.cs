// Indizadores -> Indexadores

// Recurso que nos permite acceder a una estructura de datos de tipo matriz

// Declaracion del indizador

/* 
 * EJEMPLO DEL ARRAY DE TEMPERATURAS 
var TemperaturasDiarias = new Temperaturas();

TemperaturasDiarias[3] = 11.5f;
TemperaturasDiarias[9] = 7.5f;

// Ver los datos

for(int i = 0; i < TemperaturasDiarias.len; i++)
{
    Console.WriteLine($"Item: {TemperaturasDiarias[i]}");
}
*/

// Ejemplo con los dias de la semana

var semana = new DiasSemana();
Console.WriteLine(semana["Dom"]);
try {
    Console.WriteLine(semana["Mar"]);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}   
public class Temperaturas
{
    float[] temp = new float[10]
    {
        10f, 11f,10f, 12f, 10f,
        11f, 10f, 11f,15f, 8f,
    };
    public int len => temp.Length;

    // Indizador
    public float this[int index]
    {
        get => temp[index];
        set => temp[index] = value;
    }
}

class DiasSemana 
{
    string[] dias =
    {
        "Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom"
    };
    public int this[string dias] => FindDayIndex(dias);
    private int FindDayIndex(string dia)
    {
        for (int j = 0; j < dias.Length; j++)
        {
            if (dias[j] == dia)
            {
                return j;
            }
        }
        throw new ArgumentOutOfRangeException(
            nameof(dia),
            $"El dia {dia} no esta en la lista. Comprueba si esta bien escrito en formato Lun, Mar, etc."
            );
    }
}