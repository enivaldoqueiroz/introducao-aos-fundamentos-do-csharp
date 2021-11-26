using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula71VetoresDesafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] vect = new Pessoa[10];

            Console.Write("How many rooms will rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Roon: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Pessoa ( nome, email );
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for (int i = 0;i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

            /*foreach (var i in vect)
            {
                Console.WriteLine(i);
            }*/

            Console.Read();
        }
    }
}

