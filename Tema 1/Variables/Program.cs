// int i = 0;
long l = 1;

float f = 1.5555f;
double d = 2.66666666d;

char c = 'c';
//string str = "string";

// Console.Write("int: " + i + "\n");
Console.WriteLine ("long: " + l);

Console.Write("float:" + f +"\n");
Console.WriteLine("double: " + d);

Console.Write("char: " + c + "\n");
//Console.WriteLine("string: " + str);


namespace ejercicio1
{
    class Program
    {

        public void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("mostralo " + array[i]);
            };
        }
    };
}











