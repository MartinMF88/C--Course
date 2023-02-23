using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Singleton -> logger
public sealed class Singleton
{
    static Singleton() { }

    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
    public static void MiMetodo()
    {
        Console.WriteLine("Hola desde MiMetodo");
        // Operaciones, logica, 
    }
}