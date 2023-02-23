using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    public class ConcretoFactory1 : IAbsstractFactory
    {
        public IAbsstractFactory CreateProductA()
        {
            return new ConcretoProductA1();
        }
        public IAbstractProductB CreateProdductoB()
        {
            return new ConcretoProductB1();
        }
    }
}
