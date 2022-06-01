using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSharp
{
    class Calculator
    {
        //Atributtes
        public double a;
        public double b;
        public double r;


        //Methods
        public void Suma()
        {
            r = a + b;
        }

        public void Muestra()
        {
            Console.WriteLine("a={0}, b={1}, r={2}", a, b, r);
        }
    }
}
