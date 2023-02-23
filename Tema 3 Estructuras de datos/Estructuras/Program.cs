Coords misCoordenadas = new Coords(2, 10, 0);
Console.WriteLine("x: " + misCoordenadas.X);
Console.WriteLine("y: " + misCoordenadas.Y);
Console.WriteLine("z: " + misCoordenadas.Z);

Coords misCoordenadas2 = misCoordenadas with { X = 3 };
Console.WriteLine(misCoordenadas2);

public struct Coords
{
    public Coords(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double X { get; set;} // si el item solo tiene "get" es de solo lectura, con el set podemos usarlo para otros objetos
    public double Y { get; set;}
    public double Z { get; set;}

    public override string ToString() => $"({X}, {Y}, {Z})"; // esta linea influye en como se visualiza el objeto por el terminal
}