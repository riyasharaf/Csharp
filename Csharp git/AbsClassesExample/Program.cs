namespace AbsClassesExample
{

    //Create an abstract class Animal with an abstract method MakeSound(). Implement it in classes Dog and Cat
    internal class Program
    {
        abstract class Animal
        {
            public abstract void Makesound();
            
        }
        class Dog : Animal
        {
            public override void Makesound()
            {
                Console.WriteLine("dede");
            }
        }

        class Cat : Animal
        {
            public override void Makesound()
            {
                Console.WriteLine("sjshwu");
            }
        }


        static void Main(string[] args)
        {
            //Animal a1 = new Dog(); a1.Makesound();
            //a1 = new Cat(); a1.Makesound();

            IPaymentProcessor CreditCardPayment = new CreditCardPayment(250.00, "INR", "1234567812345678", "John Doe", "12/25");
        }
    }
}
