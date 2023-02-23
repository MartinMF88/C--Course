Cliente nuevoCliente = new Cliente("Juan Perez", 33, "Pozos del Rey 1234", "jaunperez@gmail.com", true);
Console.WriteLine(nuevoCliente);
public struct Cliente
{
    public Cliente(string NombreCompleto, double Tel, string Direccion, string Email, bool Esnuevocliente
        ) : this()
    {
        this.NombreCompleto = NombreCompleto;
        this.Tel = Tel;
        this.Direccion = Direccion;
        this.Email = Email;
        this.Esnuevocliente = Esnuevocliente;
    }

    public string NombreCompleto { get; set; }
    public double Tel { get; }
    public string Direccion { get; }
    public string Email { get; }
    public bool Esnuevocliente { get; }


    public override string ToString() => $"({NombreCompleto}, {Tel}, {Direccion}, {Email}, {Esnuevocliente})";
}