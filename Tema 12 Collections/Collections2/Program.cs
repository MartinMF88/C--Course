using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;

ListarCoches();

static void ListarCoches() { 

var cars = new List<Car>
{
    {new Car() { Name = "car1", Color = "blue", Speed = 20} },
    {new Car() { Name = "car7", Color = "green", Speed = 50} },
    {new Car() { Name = "car3", Color = "green", Speed = 10} },
    {new Car() { Name = "car4", Color = "blue", Speed = 50} },
    {new Car() { Name = "car5", Color = "blue", Speed = 30} },
    {new Car() { Name = "car6", Color = "red", Speed = 60} },
    {new Car() { Name = "car2", Color = "red", Speed = 50} },
 };
    cars.Sort();
    foreach (Car coche in cars)
    {
        Console.Write($"{ coche.Color}, {coche.Name}, {coche.Speed}");
        Console.WriteLine();
    }

}

class Car : IComparable<Car>
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }

    public int CompareTo(Car other)
    {
        int compare;
        compare = String.Compare(this.Name, other.Name, true);
        if (compare == 0)
        {
            compare = this.Speed.CompareTo(other.Speed);
            compare = -compare;
        }
        return compare;
    }
}

// Clase de coleccion personalizada

public class MisColores : System.Collections.IEnumerable
{
    Colores[] _colores =
    {
    new Colores() { Nombre = "rojo" },
    new Colores() { Nombre = "azul"},
    new Colores() { Nombre = "verde"}
    };
    public System.Collections.IEnumerable GetEnumerator()
    {
        return new MisColoresEnumerator(_colores);
    }
    private class ColorEnumerator : System.Collections.IEnumerator
    {
        private Colores[] _colores;
        private int _position = -1;
        public ColoresEnumerator(Colores[] colores)
        {
            _colores = colores;
        }
        Object System.Collections.IEnumerator.Current
        {
            get
            {
                return _colores[_position];
            }
        }
        bool System.Collections.IEnumerator.MoveNext()
        {
            _position++;
            return (_position <_colores.Length);
        }
        void System.Collections.IEnumerator.Reset()
        {
            _position = -1;
        }
    }
}

public class Colores
{
   public string Nombre { get; set; }
}

// En la clase el docente no supo como resolver los errores, ademas de hacer copy paste de codigo sin explicar

