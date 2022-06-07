using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethod
{
    abstract class Person
    {
        protected Person(string name, string surnames, int age)
        {
            Name = name;
            Surnames = surnames;
            Age = age;
        }

        public string Name { get; set; }
        public string Surnames { get; set; }
        public int Age { get; set; }

        /*
         * All the sub classes have to override this method
         */
        public abstract void Show();
    }
}
