namespace OopsPractice
{


    public class Book
    {
        public string BookName { get; set; }
        public int BId { get; set; }

        public int reviews { get; set; }

        int Quantity;

        public Book(string Bookname, int id , int reviews , int quantity)
        {
            this.BookName = Bookname;
            this.BId = id;
            this.reviews = reviews;
            this.Quantity = quantity;
        }

        public void showdetails()
        {
            Console.WriteLine($"Bookname is {BookName} and its reviews is {reviews} and quantity taken is {Quantity}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Book b1 = new Book("ABC" ,1 ,5 ,2);
            //b1.showdetails();

            //Student s1 = new Student();
            //s1.sdetails();

            //Student s2 = new Student("Ayushi" , 89);
            //s2.sdetails();

            //Calculator c = new Calculator();
            //c.Add(2, 3);
            //c.Add(2, 8.3);
            //c.Add(10.23, 67.90);
            //c.Add(23.3, 45.5);

            //BankAccount account1 = new BankAccount(1,"Riya Sharaf" , 25000);
            //account1.displaybal();
            //account1.Deposit(12000);
            //account1.displaybal();


           AdvanCalc a = new AdvanCalc(10,2);
            a.Add();
            a.Sub();
            a.Mul();
            a.Divide();
      



        Console.Read();
        }
    }
}
