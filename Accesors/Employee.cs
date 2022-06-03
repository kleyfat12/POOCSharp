using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor
{
    class Employee
    {
        private double salary;
        private double tax;
        private string name;

        //Accessors (Getters and Setters)
        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetTax()
        {
            return tax;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("Salary = {0}, Tax = {1}, Name = {2}", salary, tax, name);
        }

        //Mutator
        public void CaculateTax()
        {
            tax = salary * 0.16;
        }
    }
}
