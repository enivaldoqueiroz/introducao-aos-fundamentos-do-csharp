using System;
using System.Globalization;
using Aula120ExercicioResolvido.Entities;
using Aula120ExercicioResolvido.Entities.Enums;

namespace Aula120ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department1s name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);

            Console.Write("How may contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hour): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);


            }

        }
    }
}
