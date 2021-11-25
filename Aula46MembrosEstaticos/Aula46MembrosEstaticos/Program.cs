using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula46MembrosEstaticos
{
    internal class Program
    {
        static double PI = 3.14; 
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double valume = Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + valume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
            Console.Read();
        }

        static double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * Math.Pow(r, 3.0);
        }
    }
}
