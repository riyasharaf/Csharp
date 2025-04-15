using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExamples
{

//Design a Book struct for a library system with these fields:
//Title, Author, ISBN, Price.
//Create a method inside the struct to display full book details.

    public struct Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string title , string author , double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public void Getdetails()
        { 
            Console.WriteLine($"Name is {Title} Author is {Author} and the price of book is {Price}");
        }

    }
    internal class pg
    {
    }
}
