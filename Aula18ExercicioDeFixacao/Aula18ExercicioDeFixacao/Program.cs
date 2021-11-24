using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Compitador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.364567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine("");
            Console.WriteLine($" {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


            Console.Read();
        }
    }
}
