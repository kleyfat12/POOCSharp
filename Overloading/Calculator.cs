using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Calculator
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Sum(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
