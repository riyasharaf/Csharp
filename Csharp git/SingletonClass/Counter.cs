using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{
    public class Counter
    {
        private static Counter instance = null;
        private int count = 0;

        private Counter() { }

        public static Counter Instance()
        {
            int count = 0; 
            if (instance == null)
            {
                return instance = new Counter();
            }
            return instance;
        }

        public void increment()
        {
            count++;
           
        }
        public int get()
        {
            return count;
        }
    }
}
