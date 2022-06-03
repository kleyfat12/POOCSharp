using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Employee
    {
        private double salary;
        private string name;

        private string log;

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (salary < 5000 || salary > 50000)
                {
                    LogError("SetSalary failure");
                    return;
                }
                salary = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private void LogError(string error)
        {
            log += error + "\n";
        }

        public void Show()
        {
            Console.WriteLine("Salary = {0}, Name = {1}", Salary, Name);
        }
        public void ShowLog()
        {
            Console.WriteLine(log);
        }

    }
}
