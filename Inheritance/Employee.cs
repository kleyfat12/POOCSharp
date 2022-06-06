using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    sealed class Employee : Person
    {
        public double Salary { get; set; }
        public string Position { get; set; }

        public Employee(string name, string surnames, int age, double salary, string position)
            //Base class constructor, Person
            : base(name, surnames, age)
        {
            Console.WriteLine("Employee constructor");
            Salary = salary;
            Position = position;
        }

        public void ShowEmployee()
        {
            Show();
            Console.WriteLine($"Salary: {Salary}, Position: {Position}");
        }

        public void ShowDNI()
        {
            // I can access to DNI attribute
            Console.WriteLine(DNI);
        }
    }
}
