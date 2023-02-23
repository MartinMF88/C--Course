using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    public class ConcretoProductA2 : IAbstractProductA
    {
        public string MetodoA()
        {
            return "Desde MetodoA en ProductA2";
        }
        public string OtroMetodoB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.MetodoA();
            return ($"El resultado de la colaboracion con A es: {resultado} desde ConcretoProductA2");
        }
    }
}
