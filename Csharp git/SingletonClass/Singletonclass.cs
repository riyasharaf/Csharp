using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{
    public class Singletonclass
    {
        private static Singletonclass instance = null;

        public Singletonclass()
        {

        }
        
        public static Singletonclass Instance()
        {
            if(instance == null)
            {
                instance = new Singletonclass();
            }
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton!");
        }
    }

}
