using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula76Listas_List_ParteI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine("----------------------");

            //Utilizando uma função para validar a procura
            //string s1 = list.Find(Test);
            //Console.WriteLine("First 'A': " + s1);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //Utilizando uma função lambda
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine("----------------------");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");

            foreach (var obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("----------------------");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3);
            Console.WriteLine("----------------------");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("----------------------");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }



        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
