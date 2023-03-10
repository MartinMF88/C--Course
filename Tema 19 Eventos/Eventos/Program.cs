// Eventos := editor -> suscriptor

SuscriptorCalc calculadora = new SuscriptorCalc(1, 2);
calculadora.ResultadoSuma();
calculadora.ResultadoResta();

/* Editor o Publisher
- Determina cuando se lanza el evento
   - Definicion del evento
   - Delegado
*/
public class Editor
{
    public delegate void EjemploEvento();
    public event EjemploEvento ejemploEvento;


}

public class EditorCalc
{
    public delegate void EjemploDelegado();
    public event EjemploDelegado ejemploEvento;

    public void Sumar(int a, int b)
    {
        if(ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La suma es: {a+b}");
        }
        else
        {
            Console.WriteLine($"No tienes una suscripcion al evento.");
        }
    }
    public void Restar(int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La resta es: {a - b}");
        }
        else
        {
            Console.WriteLine($"No tienes una suscripcion al evento.");
        }
    }
    public void Saludar()
    {
        Console.WriteLine("Hola");
    }
}

/* Suscriptor
- Acepta el evento y provee un event handler, es decir:
   - Metodo que sera ejecutado cuando ocurra el evento
*/
public class SuscriptorCalc
{
    EditorCalc editor;
    private readonly int A;
    private readonly int B;

    public void EjemploEventHandler()
    {
        Console.WriteLine("Se imprime el resultado de la operacion:");
    }
    public SuscriptorCalc(int a, int b)
    {
        editor = new EditorCalc();
        A = a;
        B = b;
        editor.ejemploEvento += EjemploEventHandler;
    }
    public void ResultadoSuma()
    {
        editor.Sumar(A, B);
        // metodos
    }
    public void ResultadoResta()
    {
        editor.Restar(A, B);
        editor.Saludar();
        // metodos
    }
}

/* Evento
- Delegado encapsulado en la clase del editor
- Delegado -> llama a un metodo cuando se cumple una condicion
 */