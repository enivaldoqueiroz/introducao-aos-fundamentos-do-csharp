using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula73ModificadoresDeParametrosRefEOut
{
    internal class Calculadora
    {
        public static void Triple1(int x)
        {
            x *= 3;
        }

        //Usando o modificador de parametro ref para referencias a variavel original
        public static void Triple2(ref int x)
        {
            x *= 3;
        }
        
        //Usando o modificador de parametro out para referencias a variavel original
        public static void Triple3(int origin, out int result)
        {
            result = origin * 3;
        }




    }
}
