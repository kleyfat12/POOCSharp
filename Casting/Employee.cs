using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Employee : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("HELLOOOOO!");
        }

        public void EmployeeSayHello()
        {
            Console.WriteLine("Hello from employee");
        }
    }
}
