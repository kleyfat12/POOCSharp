using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Printer
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
