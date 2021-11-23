using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19OperadoresDeAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);*/
            Console.WriteLine("----------------------------------");
            int a = 10;
            a++;
            Console.WriteLine(a);
            Console.WriteLine("----------------------------------");
            int a1 = 10;
            int b1 = a1++;
            Console.WriteLine(b1);
            Console.WriteLine(a1);
            Console.WriteLine("----------------------------------");
            int a2 = 10;
            int b2 = ++a2;
            Console.WriteLine(b2);
            Console.WriteLine(a2);

            Console.Read();
        }
    }
}
