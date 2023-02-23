Puerta door = new Puerta();
Console.WriteLine(door.ancho);
Puerta door2 = new Puerta(150, 200, 0000, false);
door.MostrarEstado();
door2.MostrarEstado();
class Puerta
{
    public int ancho;
    int alto;
    int color;
    bool abierta;

    // Constructor
    public Puerta()
    {
        ancho = 100;
        alto = 100;
        color = 0000;
        abierta = false;
    }
    public Puerta(int ancho = 100, int alto = 100, int color = 10, bool abierta = false)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
        this.abierta = abierta;
    }
    public void MostrarEstado()
    {
        Console.WriteLine($"Ancho: " +  ancho);
        Console.WriteLine($"Alto: " + alto);
        Console.WriteLine($"Color: " + color);
        Console.WriteLine($"Abierta: " + abierta);
    }
    ~Puerta()
    {
        // codigo que se ejecuta cuando se destruye una puerta (DESTRUCTOR)
        Console.WriteLine("La puerta se ha destruido");
    }
}