using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice
{

    class BasicCalc
    {
        public int num1, num2;

        public BasicCalc(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        public void Add()
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        public void Sub()
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }




    }

    class AdvanCalc : BasicCalc
    {
        public AdvanCalc(int a, int b) : base(a, b) { }
        
         
           public void Mul()
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        public void Divide()
        {
            if (num2 != 0)
                Console.WriteLine($" {num1 / num2}");
            else
                Console.WriteLine("Cannot divide by zero.");
        }




    }

}

