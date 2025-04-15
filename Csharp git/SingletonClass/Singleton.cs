using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{
    public class Singleton
    {
        private static Singleton s1 = new Singleton();
      

        private Singleton()
        {

        }

        public static Singleton getinstance()
        {
            return s1;
           
        }




    }
}
