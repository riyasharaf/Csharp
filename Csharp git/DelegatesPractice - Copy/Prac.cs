using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    public class Prac
    {
        public delegate int add(int x, int y);
        public delegate int sub(int x, int y);

        public static int sum(int x, int y)
        {
            return x + y;
        }

        public static  int minus(int x, int y)
        {
            return x - y;
        }
    }


}
