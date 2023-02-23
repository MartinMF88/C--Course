using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int edad;

             edad = 28;

             edad++;

             edad += 5;

             Console.WriteLine(edad);

             // casting o conversion explicita

             double tempratura = 29.8;

             int temperaturaMadrid;

             temperaturaMadrid = (int)tempratura;

             Console.WriteLine(temperaturaMadrid);
            */

            /*
            Console.WriteLine("Introduce el primer numero");
            int num1=  int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado resta es " + (num1 - num2));

            Console.WriteLine("El resultado suma es " + (num1 + num2));
            */

            const int valor = 5;
            // ERROR --> valor = 7; no se puede cambiar el valor de una constante

            const int valor2 = 7;

            Console.WriteLine("El valor de la constante es: {1}", valor, valor2);

            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            // double area = radio * radio * PI;

            double area = Math.Pow(radio, 2)*PI;

            Console.WriteLine("El area del circulo es: " + area);
        }
    }
}