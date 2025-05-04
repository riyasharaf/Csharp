using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegatesPractice.Calc;
using static DelegatesPractice.multicast;
using static DelegatesPractice.Prac;
using static DelegatesPractice.Program;

namespace DelegatesPractice
{
    public class multicast
    {
        public delegate void Mydel(string message);
        public delegate void Mydel2(int num);

        public  static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Num(int num)
        { 
            Console.WriteLine(num ); 
        }
            
        

      

    }
}
