﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    public interface IAbstractProductB
    {
        string MetodoB();
        string OtroMetodoB(IAbstractProductA colaborador);
    }
}
