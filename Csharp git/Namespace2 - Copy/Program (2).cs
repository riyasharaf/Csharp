using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8;
using namespace_prac;

namespace np
{
    internal class Program
    {

        static void Main(string[] args)
        {

            A a = new A();
            A.show();

            y3 b = new y3();
            b.show4();

            D a1 =  new D();
            a1.show4();


            Console.WriteLine(Class3.a3(4, 6));

            Class1 ob = new Class1();
            ob.mymth1();

            D obj1 = new D();
            obj1.mymth2();




        }
    }


   public class D : y3
    {
        public D()
        { 
            
        
        }

        public override void show4()
        {
            Console.WriteLine("From ConsoleApp np");
        }

      
    }

    class F : Class3
    {
        public F()
        {


        }

    }

    public static class XX
    {
        public static void mymth1(this Class1 ob)
        {
            Console.WriteLine("CDE");
        }


    }

    public static class XX2 
    {
        public static void mymth2(this D ob)
        {
            Console.WriteLine("Hellooo");
        }
    }

  
    
        
    }

