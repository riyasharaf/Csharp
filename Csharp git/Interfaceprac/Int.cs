using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceprac
{
    interface A1
    {
        void show(int a1);
        void print(int a2);
    }

    interface a2
    {
        void show(int a1);
        void print(int a2); 
    }

    class D: A1 , a2
    {
        public void show(int a1)
        {
            int res = a1 + a1;
            Console.WriteLine(res);
        }
         void A1.print(int a1)
        {
            Console.WriteLine("from print of a1");
        }

        void a2.print(int a2)
        {
            Console.WriteLine("from print of a2");


        }


    }


    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //C c1 = new C();
    //        //c1.add(1, 2);
    //        //c1.sub(2, 1);

    //        D d1 = new D();
    //        //d1.show(2);

    //        A1 aa = d1; aa.print(3);

    //        a2 aa2 = d1; aa2.print(1);

    //    }
    //}
}
