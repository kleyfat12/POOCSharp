using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethod
{
    class Employee : Person
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public Employee(string name, string surnames, int age, string position, double salary) : base(name, surnames, age)
        {
            Position = position;
            Salary = salary;
        }

        public override void Show()
        {
            Console.WriteLine
                ($"Name: {Name}, Surnames: {Surnames}, Age: {Age}, Position: {Position}, Salary: {Salary}");
        }
    }
}
