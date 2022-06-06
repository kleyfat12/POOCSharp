using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAttributes
{
    class Employee
    {
        private int number;
        /*
         * The static attribute is shared by all objects. 
         */
        private static int counter;

        public string Name { get; set; }
        public int Number { get { return number; } }
        public Employee(string name)
        {
            Name = name;
            number = ++counter;
        }
    }
}
