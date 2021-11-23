using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20ConversaoImplicitaECasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversão implicita entre tipos

            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            //Casting: conversao explicita entre tipos COMPATIVEIS
            double a = 5.1;
            float b = (float)a;
            Console.WriteLine(b);
            Console.WriteLine("");

            int a1 = 5;
            int b1 = 2;
            Console.WriteLine((double)a1 / b1);

            Console.Read();
        }
    }
}
