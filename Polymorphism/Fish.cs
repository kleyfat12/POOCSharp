using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The fish {Name} swims");
        }
    }
}
