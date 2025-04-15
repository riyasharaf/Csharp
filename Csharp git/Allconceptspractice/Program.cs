using System.ComponentModel;

namespace Allconceptspractice
{

    // You are developing a small library system.Each book has a title, author, and number of pages.Create a Book class that :
    //Has a constructor to initialize these values.
    //Has a method GetBookSummary() that returns a formatted string like:
    //"Book: [Title] by [Author], Pages: [Pages]".
    //Write the class and an example of creating a book object and printing the summary.

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string title , string author , int pages)
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
        }

        public void GetBookSummary()
        {
            Console.WriteLine($"Book title is {Title} and the author is {Author} and book contains {Pages} pages");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book b1 = new Book("ABC", "ABC", 78);
            //b1.GetBookSummary();


            //Student s1 = new Student("Riya" , 4, 900);
            //s1.showdet();
            //Console.Read();

            //AttendanceTracker a1 = new AttendanceTracker();
            //a1[0] = false;
            //Console.WriteLine(a1[0]);
            //a1.ShowWeeklyAttendance();

            // double Salary = 22000.00;
            // double increment = 200;

            //Salary s1 = new Salary();
            //double  result =  s1.updatesalary( ref Salary, increment);

            //double result1=  s1.updatesalary1(Salary, increment);

            // Console.WriteLine(result);
            // Console.WriteLine(result1);

            //Shoppingcart a = new Shoppingcart("ABC");
            //a[0]= new Item("Apple", 2, 50);
            //a[1] = new Item("Soap", 1, 50);

            //Console.WriteLine($"Customer: {a.CustName}");
            //Console.WriteLine($"Total items in cart: {a.totalitems()}");

            //Student1 s1 = new Student1("Riya"  , 23);
            //s1[0] = 90;
            //s1[1] = 82;
            //s1[2] = 99;
            //s1.getstudentdeatisl();

            //Library l1 = new Library("A");
            //l1[0] = "ABCD";
            //l1[1] = "HSDE";
            //l1[2] = "HHGG";

            //l1.addbook("HGGG");

            //l1.totalbooks();
            //Console.WriteLine(l1.totalbooks());

            //Theater t1 = new Theater("ABC");
            //t1[1] = true;
            //t1[2] = false;
            //t1[3] = true;
            //t1[4] = true;
            //t1[5] = true;


            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine($"Day {i}:");
            //    t1.isFull(i);
            //}
            //Console.WriteLine(t1.isFull(2));

            BankAccount b1 = new BankAccount("Riya", 20000);
            double r1 = 20000;
           b1.Deposit(ref r1, out double result);

            b1.Withdraw(ref r1, out double res);
            








        }


    }
}
