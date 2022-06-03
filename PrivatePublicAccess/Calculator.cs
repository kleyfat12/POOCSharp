using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatePublicAccess
{
    class Calculator
    {
        //Atributtes
        public double a;
        public double b;

        //Private atributte
        private double r;

        //Methods
        public void Suma()
        {
            r = a + b;
            Muestra();
        }

        // This method can only be invoked here, in Calculator
        private void Muestra()
        {
            Console.WriteLine("a={0}, b={1}, r={2}", a, b, r);
        }
    }
}
