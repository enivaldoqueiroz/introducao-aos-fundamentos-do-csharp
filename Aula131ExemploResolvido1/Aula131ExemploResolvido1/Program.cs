using Aula131ExemploResolvido1.Entities;
using System;

namespace Aula131ExemploResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name:  ");
                string name = Console.ReadLine();

                Console.Write("Hours:  ");
                int hours = int.Parse(Console.ReadLine());
                
                Console.Write("Value per hour:  ");
                double valuePerHour = double.Parse(Console.ReadLine());


                if (c == 'y')
                {
                    Employee employee1 = new Employee(name, hours, valuePerHour);
                    employee1.Payment();
                }
                else
                {
                    Employee employee1 = new OutsourcedEmployee(name, hours, valuePerHour);
                    employee1.Payment();
                }
            }
        }
    }
}
