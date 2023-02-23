/* Delegados
 * 
 * Referencia a un metodo := variable ---> metodo
 * 
 * <modificador de acceso> delegate <tipo de retorno> <nombre> (<parametros>[]);
 * 
 * public    delegate    void     ImprimirDocDelegado(string path);
 * 
 * Delegados disponibles por defecto
 * - Action<T> --> siempre devuelve void, de 0 a 16 parametros de tipo Generics
 *             --> recibe string, devuelve void
 * - Anonimos  --> 
 * - Func<in T, out TResult>
 * - Predicate<T>
 */

Console.WriteLine("Escribe un mensaje para el delegado");
string msg = Console.ReadLine();
ImprimirDelegadoClase obj = new ImprimirDelegadoClase();
obj.EjemploDelegado(msg);

// Definiciones
public delegate void ImprimirDelegado(string value);
public class ImprimirDelegadoClase
{
    private void Imprimir(string value)
    {
        Console.WriteLine($"He recibido el valor: {value}");
    }
    public void EjemploDelegado(string str)
    {
        // Declaracion
        ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Imprimir);
        // Invoacion - Call
        imprimirDelegado(str);
    }
}

public class ImprimirConActionClase
{
    private void Imprimir(String msg)
    {
        Console.WriteLine(msg);
    }
    public void EjemploAction(string msg)
    {
        Action<string> imprimirDelegadoAction = Imprimir;
        imprimirDelegadoAction(msg);
    }
}