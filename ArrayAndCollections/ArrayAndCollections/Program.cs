using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] a = new string[3];
            a[0] = "Danilo";
            a[1] = "Sheila";
            a[2] = "Lana";

            Array.Sort(a);
            int size = a.Length;

            foreach (string nome in a)
            {
                Console.WriteLine(nome);
            }

            if(Array.Exists(a, e => e.IndexOf ("Lana") != -1))
            {
                Console.WriteLine("Existe a Lana no array");
            }
            Console.WriteLine("===============================================");
            //Collections

            List<string> a1 = new List<string>();
            a1.Add("Danilo");
            a1.Add("Sheila");
            a1.Add("Lana");
             
            Console.WriteLine(a1[0]);
            Console.WriteLine(a1.Count);

            a1.Sort();
            foreach (string nome in a1)
            {
                Console.WriteLine(nome);
            }
            if (a1.Exists(e => e == "Lana"))
            {
                Console.WriteLine("Encontrei a Lana na collection");
            }

            Console.Read();
        }
    }
}
