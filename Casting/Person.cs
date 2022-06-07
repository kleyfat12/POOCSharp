using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Person
    {
        public virtual void SayHello()
        {
            Console.WriteLine("HELLO");
        }

        public void PersonSayHello()
        {
            Console.WriteLine("Hello from person");
        }
    }
}
