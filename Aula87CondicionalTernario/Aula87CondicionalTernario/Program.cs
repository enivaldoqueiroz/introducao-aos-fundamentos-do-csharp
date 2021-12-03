using System;
using System.Globalization;

namespace Aula87CondicionalTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);


            //Condicional if
            /*double desconto;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            } else
            {
                desconto = preco * 0.05;
            }*/

            //Condicional Ternario
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

            Console.Read();

        }

    }
}
