using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loop - While
            /*int a = 1;
            while (a <= 10)
            {
                if (a == 1)
                {
                    a++;
                    continue;
                }
                Console.WriteLine(a);
                a++;
            }*/

            //Loop - Do While
            /*int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 3);*/

            //Loop - For
            /*for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(a);
            }*/

            //Loop - Foreach
            /*int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }*/

            //Loop - com função recursiva
            looping(1);

            Console.ReadLine();

        }
        //Loop - com função recursiva
        public static void looping(int a)
        {
            Console.WriteLine(a);
            if(a < 3)
            {
                looping(a + 1);
            }
        }

    }
}
