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

        //Constructor overload
        public Person(string name)
        {
            Name = name;
            Age = 18;
        }

        public void Show()
        {
            Console.WriteLine("Name = {0}, Age = {1}", Name, Age);
        }

        /*
        .NET 5 (including .NET Core) or a later version: 
        There's no output, because this implementation of .NET doesn't 
        call finalizers (destructors) when the application terminates.
         */
        ~Person()
        {
            Console.WriteLine("Message form person destructor");
        }
    }
}
