using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula75Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] {"Maria", "Alex","Bob" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-----------------------------");

            foreach (string i in vect)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
