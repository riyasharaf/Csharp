using System.Diagnostics;

namespace SingletonClass
{

    public  class Abc
    {
        static Abc a1 = new Abc();  
        private Abc()
        {

        }
        public static Abc getinstance()
        {
            return a1;
        }

         
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Abc obj1 = Abc.getinstance();
            //Abc obj2 = Abc.getinstance();

            //Singletonclass s11 = Singletonclass.Instance();
            //Singletonclass s12 = Singletonclass.Instance();

            //s12.ShowMessage();
            //s11.ShowMessage();

            //Console.WriteLine(ReferenceEquals(s11, s12));
            

            Counter c1 = Counter.Instance();
            Counter c2 = Counter.Instance();

            c1.increment();
            c2.increment();

            Console.WriteLine(c1.get());
            Console.WriteLine(c2.get());

        }
    }
}
