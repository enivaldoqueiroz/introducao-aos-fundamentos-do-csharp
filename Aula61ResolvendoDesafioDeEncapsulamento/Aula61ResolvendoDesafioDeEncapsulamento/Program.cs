using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula61ResolvendoDesafioDeEncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria();

            Console.Write("Entre o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            c1.Numero = numeroConta;

            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            c1.Titular = nomeTitular;

            Console.Write("Haverá depósito inicial (s/n)? ");
            char simOuNao = char.Parse(Console.ReadLine());

            c1.SimoOuNão(simOuNao);

            Console.WriteLine(c1.ToString());

            Console.Read();
        }
    }
}
