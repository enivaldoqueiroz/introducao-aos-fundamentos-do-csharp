using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula56Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);

            //Console.WriteLine(p.Nome);
            Console.WriteLine();
            //p.SetNome("TV 4K");
            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            Console.Read();
        }
    }
}
