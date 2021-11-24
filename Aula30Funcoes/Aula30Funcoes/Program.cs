using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula30Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //Sem o uso de função
            /*if (n1 >= n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }*/

            //Com o uso de uma função
            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior dos números é = " + resultado);

            Console.ReadLine();
        }

        static int Maior(int a, int b, int c)
        {
            int maior;
            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }
            return maior;
        }
    }
}
