using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula70VetoresII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de indice do vertor");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome e o proço do produto: ");
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price};
            }
            double soma = 0.0;

            for (int i = 0;i < n; i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;

            Console.WriteLine("Average price = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.Read();
        }
    }
}
