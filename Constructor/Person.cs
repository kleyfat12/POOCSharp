using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Person
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Show()
        {
            Console.WriteLine("Name = {0}, Age = {1}", Name, Age);
        }
    }
}
