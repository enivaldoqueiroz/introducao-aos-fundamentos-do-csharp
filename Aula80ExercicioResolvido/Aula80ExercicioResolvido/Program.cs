using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula80ExercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
                Fazer um programa para ler um número inteiro N e uma matriz de
                ordem N contendo números inteiros. Em seguida, mostrar a diagonal
                principal e a quantidade de valores negativos da matriz.
            */

            Console.WriteLine("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i,i] + " ");
            }

            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
            /*foreach (var obj in mat)
            {
                Console.Write(obj);
            }*/

            Console.ReadLine();
        }
    }
}
