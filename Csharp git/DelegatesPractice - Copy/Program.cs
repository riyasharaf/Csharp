using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{

    
    public class Program
    {
       
            public delegate void delabc(string message);
            public delegate void df(int x);
            public delegate int ff(int z);

            public static void show(string message)
            {
                Console.WriteLine(message);
            }
            public static int mym(int z)
            {
                return z;   
            }
            public static void show1(int xyy)
            {
                Console.WriteLine(xyy);
            }


        
        


      
    }
}
