using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula79Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matriz mat de 2 linhas e 3 colunas
            double[,] mat = new double[2, 3];

            //Verifica o tamanho com Length
            Console.WriteLine(mat.Length);
            //Verifica a quantidade de linhas Rank
            Console.WriteLine(mat.Rank);

            //Verifica a dimenção da matriz com GetLength
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

            Console.ReadLine();
        }
    }
}
