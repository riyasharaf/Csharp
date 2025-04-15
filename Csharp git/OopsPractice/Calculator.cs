using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice
{
    internal class Calculator
    {

        

        public void Add(int x ,int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public void Add(double x , double y)
        {
            double result = x + y;
            Console.WriteLine(result);
        }

        public void Add(int x ,double y)
        {
            double result = x + y;
            Console.WriteLine(result);
        }

        public void Add(decimal x , decimal y)
        {
            decimal result = x + y;
            Console.WriteLine(result);
        }
    }
}
