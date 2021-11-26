using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula68Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Operador de coalescência nulo
            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("");

            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);

            }
            else
            {
                Console.WriteLine("X is null");

            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            Console.Read();
        }
    }
}
