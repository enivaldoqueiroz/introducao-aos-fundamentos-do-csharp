using Aula133ExercicioPropostoHerancaEPolimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Aula133ExercicioPropostoHerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 133. Exercício proposto (herança e polimorfismo)

            List<Product> listProduct = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (c == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    listProduct.Add(new ImportedProduct(name, price, customsFee));
                }
                if (c == 'c')
                {
                    listProduct.Add(new Product(name, price));
                }
                if (c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    listProduct.Add(new UsedProduct(name, price, manufacture));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product productList in listProduct)
            {
                Console.WriteLine(productList.PriceTag());
            }
        }
    }
}
