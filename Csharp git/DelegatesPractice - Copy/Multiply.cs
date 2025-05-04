using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{

    //    Write a method ExecuteOperation that takes a delegate as a parameter.
    //Call it with an anonymous method that multiplies two numbers.
    public delegate int operationsss(int x, int y);

    
    internal class Multiply
    {
        public static void ExecutionOperation(operationsss op)
        {
            int result = op(5, 6);
            Console.WriteLine("Result: " + result);
        }
        
        static void Main(string[] args)
        {

            ExecutionOperation(delegate (int a, int b)
            {
                return a * b;
            });


            Operation o1 = delegate (int x, int y)
            {
                return x + y;

            };
            Console.WriteLine(o1(3, 4));

            Operation o2 = delegate (int x, int y)
            {
                return x - y;
            };
            Console.WriteLine(o2(6, 2));

            //multicasting

            Abc a1 = delegate (string message)
            {
                Console.WriteLine(message);
            };

            a1 = a1 + delegate (string message)
            {
                Console.WriteLine(message);
            };

            a1("Helloo Riya");


            //Sayhi h1 = delegate (string name)
            //{
            //    Console.WriteLine("Helloo" + name);
            //};

            //h1("Riyaaaa");
            //Mydel d1 = new Mydel(Print);
            //d1("Riya");

            //Mydel d2 = new Mydel(Print);
            //d2("Prashant");

            //Mydel d3 = d1 + d2;
            //Console.WriteLine(d3);

            //Mydel2 d4 = new Mydel2(Num);
            //Mydel2 d5 = new Mydel2(Num);


            //Mydel2 d6 = d4 + d5;
            //d6(100);




            //CalcDelegate c1 = new CalcDelegate(mysum);
            //c1(3, 4);

            //CalcDelegate c2 = new CalcDelegate(mysub);
            //c2(6, 4);

            //CalcDelegate c3 = new CalcDelegate(mymul);
            //c3(6, 4);


            //delabc a1 = show;
            //a1("Hey its Ayushi");

            //delabc a2 = new delabc(show);
            //a2("Its Riya");

            //Prac.sum(2, 3);

            //Prac.add a3 = Prac.sum;
            //a3(2, 3);
            //Console.WriteLine(a3(4, 5));

            //ff f1 = new ff(mym);
            //f1(3);
            //Console.WriteLine(f1(3));



        }
    }
}
