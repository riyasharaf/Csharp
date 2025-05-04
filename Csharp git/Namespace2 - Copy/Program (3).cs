using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8;
using np;
using namespace_prac;
using System.Net.Http.Headers;

namespace nsp

{
     
    class C : R
    {
        public int Phonenum {  get; set; }
        public C(string name, int ID , int phnomber): base(name , ID)
        {
            this.Phonenum = phnomber;
        }

        public void show2()
        {
            Console.WriteLine($" {Name} , {ID} , {Phonenum}");
        }

    }

   
    internal class Program
    {

        
        static void Main(string[] args)
        {

            C c1 = new C("Riya" , 1 , 786777);
            c1.show2();
            
            A55 a = new A55();
            Console.WriteLine(a.show(1));
        }
    }
}
