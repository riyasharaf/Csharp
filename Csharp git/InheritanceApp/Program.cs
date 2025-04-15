namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog breed1 = new Dog();
            breed1.makesound();

            Cat cat1 = new Cat();
            cat1.makesound();

            Console.ReadLine();
            
           
        }


        class Animal
        {
            public void eats()
            {
                Console.WriteLine("Eating.........");
            }

            public virtual void makesound()
            {
                Console.WriteLine("Animals in general make different sounds!!!");
            }
        }

        class Dog : Animal
        {
            public  override void  makesound()

            {

                //use of base keyword in inheritance.
                base.makesound();
                Console.WriteLine("Barking.........");

            }
        }

        class Cat : Animal
        {
             public override void makesound()
            {
                Console.WriteLine("Meowssss.....");
            }
        }
    }
}
