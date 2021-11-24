using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4AdicaoERemocaoDeProdutosComOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.Write("Entre os dados do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.Read();
        }
    }
}
