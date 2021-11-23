using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string  frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("Voce digitou: " + frase);
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/

            //Separando as palavras
            //string s = Console.ReadLine();
            /*string[] vet = Console.ReadLine().Split(' '); //Outra forma de fazer
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);*/

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
            


        }
    }
}
