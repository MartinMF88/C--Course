using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    public class ConcretoFactory2 : IAbstractFactory
    {
        public IAbsstractFactory CreateProductA()
        {
            return new ConcretoProductA2();
        }
        public IAbstractProductB CreateProdductoB()
        {
            return new ConcretoProductB2();
        }
    }
}
