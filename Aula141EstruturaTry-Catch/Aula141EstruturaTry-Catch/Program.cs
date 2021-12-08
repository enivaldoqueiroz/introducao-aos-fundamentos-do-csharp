using System;

namespace Aula141EstruturaTry_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 141. Estrutura try-catch

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DIvision by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }

        }
    }
}
