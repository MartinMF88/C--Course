// Herencia
Vehiculo vehiculo = new Vehiculo();
vehiculo.Arrancar();
// vehiculo.DetenerCoche(); este metodo no esta implementado en la clase padre

coche coche = new coche();
coche.Arrancar();
coche.Arrancar("Martin");

//CLASE PADRE - PARENT
class Vehiculo
{
    public float combustible { get; set; }
    public int aforo { get; set; }
    public void Arrancar()
    {
        Console.WriteLine("Este vehiculo ha arrancado.");
    }
}

//CLASE CHILD O HIJA
class coche : Vehiculo
{
    public int ruedas { get; set; }
    public void Arrancar()
    {
        Console.WriteLine("Este coche ha arrancado con exito.");
    }
    public void Arrancar(string str)
    {
        Console.WriteLine($"{str} ha arrancado este coche a las {DateTime.Now.ToShortTimeString()}. ");
    }
    public void DetenerCoche()
    {
        Console.WriteLine("Este vehiculo se ha detenido");
    }
}