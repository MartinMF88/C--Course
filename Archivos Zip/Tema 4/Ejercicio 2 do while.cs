Console.WriteLine("Escribe el ancho: ");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe el largo: ");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Es relleno? Indica True o False: ");
bool relleno = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Escribe un numero para definir cuantas copias quieres: ");
int copias = Convert.ToInt32(Console.ReadLine());

int modAlto = alto;
while (modAlto > 0)
{
    int modCopias = copias;
    while (modCopias >= 1)
    {
        int modAncho = ancho;
        while (modAncho > 0)
        {
            if (relleno)
            {
                Console.Write("*");
                modAncho--;
            }
            else
            {
                if ((modAlto == alto || modAncho == ancho) || (modAlto == 1 || modAncho == 1))
                {
                    Console.Write("*");
                    modAncho--;
                }
                else if (modAlto != alto && modAlto != 1)
                {
                    Console.Write(" ");
                    modAncho--;
                }
            }
        }
        if (modCopias > 1)
        {
            Console.Write("  ");
        }
        modCopias--;
    }
    Console.Write("\n");
    modAlto--;
}