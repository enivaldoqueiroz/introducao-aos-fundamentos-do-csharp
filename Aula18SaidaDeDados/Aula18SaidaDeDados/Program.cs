using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            int idade2 = 32;
            double saldo2 = 10.35784;
            string nome2 = "Maria";

            //PlaceHolder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade2, saldo2);

            //Interpolação
            Console.WriteLine($"{nome2} tem {idade2} anos e tem saldo igual a {saldo2:F2} reais");

            //Concatenação de Strings
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            Console.Read();
        }
    }
}
