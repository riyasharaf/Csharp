namespace Inheritance
{

    class Animal
    {
       public  int by1;
      public  Animal()
        {
            by1 = 12;
        }

        public virtual void a(int a , int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        public void h()
        {
            Console.WriteLine("hello");
        }

       
       
    }

    class Dog : Animal
    {

        public int i;

        public Dog()
        {
            i = 90;
        }


       
        public void show()
        {
            Console.WriteLine($"the value is {i+by1}");
        }

        public override void a(int a, int b)
        {

            base.a(a, b);
            int result = a * b;
            Console.WriteLine(result);
        }

        public new void h()
        {
            Console.WriteLine("Helloo from new method");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //Dog d1 = new Dog();
            //d1.show();

            //d1.a(4, 2);

            Animal a1 = new Animal();
            a1.h();

            Animal a2 = new Dog();
            a2.h();

            Dog d1 = new Dog();
            d1.h();

            

          
        }
    }


}
