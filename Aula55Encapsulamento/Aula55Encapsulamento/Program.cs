using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula55Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            Console.Read();
        }
    }
}
