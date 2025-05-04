using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_prac

{
    public class Class1
    {
        public void a1()
        {

            Console.WriteLine("Hello  from ddl class class1");
        }
    }

    public class Class2
    {
        public void a2() 
        {
            Console.WriteLine($"hello from ddl class");
        }
    }

    public class Class3
    {
        public static int a3(int r1, int r2)
        {
            return r1 + r2;
        }

    }

    public class R
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public R(string name, int ID)
        {
            this.Name = name;
            this.ID = ID;
        }

        public void show()
        {
            Console.WriteLine($"Name : {Name} ID: {ID}");
        }


    }
    public struct A55
    {

        public int show(int y1)
        {
            return y1;
        }
    }





}
