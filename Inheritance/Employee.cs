using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person
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

        /*
         * Although in the base class it is not marked as virtual, 
         * you can overwrite a method with new, but polymorphism is lost
         */
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Salary: {Salary}, Position: {Position}");
        }

        public override void BetterShow()
        {
            base.BetterShow();
            Console.WriteLine($"with salary of ${Salary} and position {Position}");
        }

        public void ShowDNI()
        {
            // I can access to DNI attribute
            Console.WriteLine(DNI);
        }
    }
}
