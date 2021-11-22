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
            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 3);

        }
    }
}
