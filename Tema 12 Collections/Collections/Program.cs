// Collections

// Colección de strings

var coches = new List<string>();
coches.Add("Ford");
coches.Add("BMW");
coches.Add("Peugeot");

var coches2 = new List<string> { "Suzuki", "Volkswagen", "Fiat"};

foreach (var el in coches2)
{
    Console.WriteLine(el + " ");
}

List<Elemento> elemento = CrearLista();

var query = from el in elemento where el.NumeroAtomico <= 20
            select el;
foreach (Elemento el in query)
{
    Console.WriteLine($"Nombre: {el.Nombre}, Simbolo: {el.Simbolo}, Numero Atomico: {el.NumeroAtomico}.");
}
static List<Elemento> CrearLista()
{
    return new List<Elemento>
    {
        {new Elemento() {Simbolo = "K", Nombre = "Potasio", NumeroAtomico = 19} },
        {new Elemento() {Simbolo = "Ca", Nombre = "Calcio", NumeroAtomico = 20} },
        {new Elemento() {Simbolo = "Ti", Nombre = "Titanio", NumeroAtomico = 22} }
    };
}
public class Elemento
{
    public string Simbolo { get; set; }
    public string Nombre { get; set; }
    public int NumeroAtomico { get; set; }
}