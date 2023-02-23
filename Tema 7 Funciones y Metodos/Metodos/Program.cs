// METODOS

var moto = new Motos();
Motos.Arrancar();   // metodo que se aplica a public static void
moto.ArrancarMoto();  // metodo que se aplica a public void


//Extension
Metodos_1.ExtensionMotos.Acelerar();

//Retornos de metodos
int gasolina = moto.CantidadGasolina();
Console.WriteLine($"Nos quedan {gasolina} litros de combustible.");
dynamic nivelDeposito = moto.EcharGasolina(10.5);  // la palabra dynaimc ajusta el tipo de dato al valor recibido
Console.WriteLine($"Ahora tenemos {nivelDeposito} litros de combustible.");


// Definiciones
class Motos
{
    public static void Arrancar()
    {
        Console.WriteLine("Arranca Motos");
    }
    public void ArrancarMoto()
    {
        Console.WriteLine("Arranco esta moto");
    }
    public int CantidadGasolina()
    {
        // codigo
        int gasolina = 20; // litros
        return gasolina;
    }
    public int EcharGasolina(int litros)
    {
        int nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
    public float EcharGasolina(float litros)
    {
        float nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
    public double EcharGasolina(double litros)
    {
        double nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
}
