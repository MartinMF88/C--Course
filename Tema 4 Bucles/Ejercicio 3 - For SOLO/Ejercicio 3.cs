Console.WriteLine("Ingrese el valor de alto: ");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor de ancho: ");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indique escrbiendo true si es releno o false si no lo es: ");
bool relleno = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Indique el número de copias: ");
int copias = Convert.ToInt32(Console.ReadLine());

int Valalto = alto;
while (Valalto > 0)
{
    int Valcopias = copias;
    while (Valcopias >= 0)
    {
        int Valancho = ancho;
        while (Valancho > 0)
        {
            if (relleno)
            {
                Console.Write("*");
                Valancho--;
            }
            else
            {
                if(Valalto == alto || Valancho == ancho || Valalto == 1 || Valancho == 1)
                {
                    Console.Write("*");
                    Valancho--;
                }
                else if(Valalto != alto || Valalto != 1)
                {
                    Console.Write(" ");
                    Valancho--;
                }
            }
        }
        Console.Write("  ");
        Valcopias--;
    }
    Console.Write("\n");
    Valalto--;
}