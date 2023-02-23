Puerta door = new Puerta();
door.CambiarAlto(180.5f); // centimetros
door.CambiarAncho(50);
door.PintarPuerta("Verde");// centimetros
door.Abrir();
door.MostrarEstado();
door.Cerrar();
door.MostrarEstado();


public class Puerta
{
    int ancho;
    int alto;
    string color;
    string material = "madera"; // en esta seccion se pueden dar valores por defecto a todos los parametros
    bool abierta;

    public void CambiarAlto(int n)
    {
        alto = n;
    }
    public void CambiarAlto(float f)
    {
        alto = Convert.ToInt32(f);
    }
    public void CambiarAncho(int m)
    {
        ancho = m;
    }
    public void PintarPuerta(string color)
    {
        this.color = color;
    }

    public void Abrir()
    {
        abierta = true;
    }
    public void Cerrar()
    {
        abierta = false;
    }
    public void MostrarEstado()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Material: {0}", material);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta? {0}", abierta);
    }
}