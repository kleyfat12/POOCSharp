using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*
     * Administrator can not inerit from Employee, it is marked as sealed
     */
    class Administrator : Employee
    {
        public Administrator(string name, string surnames, int age, double salary, string position) : base(name, surnames, age, salary, position)
        {
        }

        /*
         * I can not override the Show method
         */

        //public override void Show()
        //{
        //    base.Show();
        //}
    }
}
