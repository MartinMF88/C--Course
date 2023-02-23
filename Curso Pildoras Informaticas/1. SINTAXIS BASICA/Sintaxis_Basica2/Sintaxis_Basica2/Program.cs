using System;

namespace Sintaxis_Basica2
{
    class Program
    {   
        static void Main(string[] args)
        {
            /* COMENTADO 1.
            mensajeEnPantalla();

            Console.WriteLine("Mensaje desde el Main");

            sumaNumeros(7, 5);
            
            Console.WriteLine(sumaNumeros(7, 9));
            */

            /* COMENTADO 2. 
            Console.WriteLine(Suma(7,5.3));
            */
            int valor1 = 7;

            double valor2 = 5.2;

            double valor3 = 8.3;
            
            Console.WriteLine(Suma(valor1, valor2, valor3));


            Console.WriteLine(Suma(7, 5.3));

        }

        /* COMENTADO 1. 
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
        }

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("La suma de los numeros es: " + num1+num2);
            Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
        }
        

        // METODOS RETURN
        static int sumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }
        */

        /* COMENTADO 2
        static int Suma(int operador1, int operador2)=> operador1 + operador2;

        static int Suma(int numero1, double numero2) => numero1;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;
        */

        private static double Suma(int v1, double v2)
        {
            return v1 + v2;
        }


        // SOBRECARGAS 

        private static double Suma(int num1, double num2, double num3 = 0)
        {
            return num1 + num2 + num3;
        }
    }
}