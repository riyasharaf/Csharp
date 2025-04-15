using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allconceptspractice
{

    //Create a method UpdateSalary(ref double salary, double increment) that increases the salary by a given increment.
    //Demonstrate calling the method using ref and show how the value is updated in the calling method
    internal class Salary
    {
        public int salary {  get; set; }
        public int increment {  get; set; }

       
        public double updatesalary(ref double salary , double increment)
        {
            salary = salary + increment;
            return salary;
        }

        public double updatesalary1( double salary, double increment)
        {
            salary = salary + increment;
            return salary;
        }
    }
}
