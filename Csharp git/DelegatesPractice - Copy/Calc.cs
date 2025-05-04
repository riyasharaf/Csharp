using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static DelegatesPractice.Program;

namespace DelegatesPractice
{
    //Create a delegate CalcDelegate that takes two integers and returns an integer.Use it to point to methods like Add, Subtract, and Multiply
    public class Calc
    {
        public delegate int CalcDelegate(int x, int y);

        public static int mysum(int x , int y)
        {
            return x + y;
        }

        public static int mysub(int x, int y)
        {
            return x - y;
        }
        public static int mymul(int x, int y)
        {
            return x * y;
            
        }
       
    }
}
