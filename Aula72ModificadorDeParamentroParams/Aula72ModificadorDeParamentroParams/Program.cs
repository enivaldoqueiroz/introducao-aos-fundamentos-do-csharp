using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula72ModificadorDeParamentroParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
