using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The cat {Name} moves walks");
        }
    }
}
