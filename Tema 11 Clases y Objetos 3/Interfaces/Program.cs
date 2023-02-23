// Interfaces: son clases que definen atributos, metodos, etc, sin implementar.

Vehiculo vehiculo = new Vehiculo();
vehiculo.Marca = "marca";
interface IVehiculo
{
    void Arrancar();
    public string Marca { get; set; }
}

class Vehiculo : IVehiculo
{
    public string Marca { set; get; }
    void IVehiculo.Arrancar()
    {
        Console.WriteLine("Arrancar.");
    }
}