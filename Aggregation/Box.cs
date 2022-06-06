using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Box
    {
        private int number;
        private Ball? ball = null;

        private static int counter;

        public int Number { get { return number; } }
        public Ball Ball
        {
            get { return ball; }
            set
            {
                if (ball != null)
                {
                    return;
                }
                ball = value;
            }
        }

        public Box()
        {
            number = ++counter;
        }

        public void Show()
        {
            if (ball != null)
            {
                Console.WriteLine($"A box with a {Ball.Color} ball");
            }
            else
            {
                Console.WriteLine("There is no ball in the box");
            }
        }
    }
}
