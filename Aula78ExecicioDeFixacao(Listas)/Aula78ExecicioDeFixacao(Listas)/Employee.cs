using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula78ExecicioDeFixacao_Listas_
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salary { get; set; }
        public Employee(int id, string nome, double salary)
        {
            Id = id;
            Nome = nome;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentage)
        {
            Salary = (Salary * (porcentage/100)) + Salary;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + " "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
