using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula34EstruturaDeRepeticaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Valor #{i}:");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"Soma = {soma}");
            Console.Read();
        }
    }
}
