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
        private string name = "";
        private string log = "";

        //Accessors (Getters and Setters)
        public double GetSalary(int password)
        {
            if (password != 12345)
            {
                LogError("GetSalary failure");
                return 0;
            }
            return salary;
        }

        public void SetSalary(double salary)
        {
            if (salary < 5000 || salary > 50000)
            {
                LogError("SetSalary failure");
                return;
            }
            this.salary = salary;
            CalculateTax();
        }

        public double GetTax(int password)
        {
            if (password != 12345)
            {
                LogError("GetTax failure");
                return 0;
            }
            return tax;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            if (name.Length <= 3)
            {
                LogError("SetName failure");
            }
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("Salary = {0}, Tax = {1}, Name = {2}", salary, tax, name);
        }

        public void ShowLog()
        {
            Console.WriteLine(log.Equals("") ? "No log yet" : log);
        }

        //Mutators
        private void CalculateTax()
        {
            tax = salary * 0.16;
        }

        private void LogError(string error)
        {
            log += error + "\n";
        }
    }
}
