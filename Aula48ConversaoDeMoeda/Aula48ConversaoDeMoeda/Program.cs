using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula48ConversaoDeMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Execício de fixação 
             * 
             * Faça um programa para ler a cotação do dolar, e depois um valor em dolares
             * a ser comprado por uma pessoa em reais. Informar quantos reais a pessoa vai pagar
             * pelos dolares, considerando ainda que a pessoa tera que pafar 6% de IOF sobre o valor
             * em dolar. Criar uma classe ConversorDeMoeda para ser respnsavel pelos calculos
             * 
             */

            Console.Write("Qual é a contação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares vc vai comprar? ");
            double quantidadeDeDolares = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            double conversaoParaDolares = ConversorDeMoeda.ConversaoEmReais(cotacao, quantidadeDeDolares);
            Console.Write("Valor a ser pago em reais = " + conversaoParaDolares.ToString("F2", CultureInfo.CurrentCulture));

            Console.Read();
        }
    }
}
