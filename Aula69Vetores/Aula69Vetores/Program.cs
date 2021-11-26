using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula69Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os valores: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0;i < n; i++)
            {
                soma += vect[i];
            }

            double media = soma / n;

            Console.WriteLine("Media da altura: " + media.ToString("F2", CultureInfo.InvariantCulture));

            /*foreach (int i in vect)
            {
                Console.Write(i + " ");
            }*/

            Console.Read();
        }
    }
}
