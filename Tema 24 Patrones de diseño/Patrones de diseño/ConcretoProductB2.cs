﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    public class ConcretoProductB2 : IAbstractProductB
    {
        public string MetodoB()
        {
            return "Desde MetodoB en ProductB1";
        }
        public string OtroMetodoB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.MetodoA();
            return ($"El resultado de la colaboracion con A es: {resultado} desde ConcretoProductB2");
        }
    }
}
