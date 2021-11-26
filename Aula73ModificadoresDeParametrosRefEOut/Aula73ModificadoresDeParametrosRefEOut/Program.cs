using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula73ModificadoresDeParametrosRefEOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            //Sem o uso de modificador, a tri
            Calculadora.Triple1(a);

            //Usando o modificador de parametro ref para referencias a variavel original
            int b = 10;
            Calculadora.Triple2(ref b);
            Console.WriteLine(b);

            //Usando o modificador de parametro out para referencias a variavel original
            int c = 10;
            int triple;
            Calculadora.Triple3(c, out triple);
            Console.WriteLine(triple);



            Console.Read();
        }
    }
}
