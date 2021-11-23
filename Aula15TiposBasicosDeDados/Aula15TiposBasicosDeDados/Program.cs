using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15TiposBasicosDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 's';
            char letra = '\u0041';
            sbyte n1 = 100;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string n7 = "Maria Green";
            object n8 = "Alex Brown";
            object n9 = 42.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3); 
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);

            Console.WriteLine("----------------------------");

            int n10 = int.MinValue;
            int n11 = int.MaxValue;
            sbyte n12 = sbyte.MinValue;
            decimal n13 = decimal.MaxValue;

            Console.WriteLine(n10);
            Console.WriteLine(n11);
            Console.WriteLine(n12);
            Console.WriteLine(n13);

            Console.Read();
        }
    }
}
