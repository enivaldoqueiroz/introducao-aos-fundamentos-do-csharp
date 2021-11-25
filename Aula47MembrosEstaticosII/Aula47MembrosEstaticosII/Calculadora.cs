﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula47MembrosEstaticosII
{
    internal class Calculadora
    {
        public static double PI = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * Math.Pow(r, 3.0);
        }
    }
}
