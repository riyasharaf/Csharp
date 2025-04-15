namespace StructuresExamples
{
    interface C
    {
        //inheritance possible through interface.
    }
    struct A : C
    {
        public int x ;
        public int y ;

        public A(int x , int y)
        {
            this.y = y;
            this.x = x;
        }

        public int x1 { get; set; }
        public int y1 { get; set; } 


        public int abc(int x, int y)
            {
            return x * y;
            }
        public int xyz(int x1 , int y1) 
        { 
            return x1 * y1;
        }

       
    }
    
    public class Program 
    {
        static void Main(string[] args)
        {

            //using default constructor
            //A a = new A();
            // Console.WriteLine(a.abc(1, 2));

            //initialize values
            //A b = new A();

            //b.x = 3;
            //b.y = 5;

            //b.abc(b.x, b.y);

            //parameterized constructor
            //A c = new A(10,20);

            //Console.WriteLine(c.abc(c.x, c.y));

            //Book b = new Book("abc" , "bcd" , 2200);
            //b.Getdetails();

            Point2D p1 = new Point2D(10,20);
            Point2D p2 = new Point2D(20, 30);
            double res = p1.DistanceTo(p2);
            Console.WriteLine(res);
            
        }
    }
}
