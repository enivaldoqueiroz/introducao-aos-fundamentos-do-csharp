using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula131ExemploResolvido1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int  Hour { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hour, double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        public void Payment()
        {
            ValuePerHour = Hour * ValuePerHour;
        }

        public override string ToString()
        {
            return Name
                + " - "
                + ValuePerHour;
        }
    }
}
