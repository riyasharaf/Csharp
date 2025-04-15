namespace Interfaceprac
{

    interface A
    {
        public void add(int a , int b);
        
    }
    interface B
    {
        public void sub(int a , int b);
    }

    public class C : A, B 
    { 
        public void add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a , int b)
        {
            Console.WriteLine(a - b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //C c1 = new C();
            //c1.add(1, 2);
            //c1.sub(2, 1);

            IFly a1 = new IFlyingcar();
            a1.fly("Abc");



        }
    }
}
