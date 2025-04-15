using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Allconceptspractice
{

// 2. Library System
//Create a Library class that :
//Holds up to 10 books using a private array
//Use an indexer to access books by index
//Property: LibraryName
//Method: AddBook(string bookName) adds to the next available slot
//Method: GetTotalBooks()
    internal class Library
    {
       
        public string Libraryname {  get; set; }
        private string[] Books = new string[10];

        public string this[int index] 
        {
            get { return Books[index]; }
            set { Books[index] = value;}
        }

        public Library(string Libraryname)
        {
            this.Libraryname = Libraryname;
        }

        public void addbook(string Book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] == null)
                {
                    Books[i] = Book;
                    Console.WriteLine($"'{Book}' added to the library.");
                    return;
                }
            }
            Console.WriteLine("Library is full. Cannot add more books.");
        }

        public int totalbooks()
        {
            int count = 0;

            foreach (var book in Books)
                if (!string.IsNullOrEmpty(book))
                {
                    { count++; }
                }
            return count;
        }





    }
}
