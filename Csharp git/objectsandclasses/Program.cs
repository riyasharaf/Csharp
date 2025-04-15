namespace objectsandclasses
{


    class car
    {


        private string _model;
        private string _name;

        //constructor of a class
        public car(string model, string name)

        {
            Console.WriteLine($" a {name} of model {model} has been created");
        }



    }
    class calculation
    {
        public void sumoftwonum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        public void sumoftwonum(int c)
        {
            int r1 = c * c;
            Console.WriteLine();
        }

    }

 
    internal class Program
    {

       
        static void Main(string[] args)
        {
            car bmw = new car("i7" , "bmw");

            calculation c = new calculation();
            c.sumoftwonum(4, 5);

            c.sumoftwonum(4);
           

        }
    }
}
