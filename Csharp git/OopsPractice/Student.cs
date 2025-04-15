using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice
{
    internal class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }


        //parameterized constructor
        public Student(string sname , int smarks )
        {
            this.Name= sname;
            this.Marks= smarks; 
        }


        //default constructor
        public Student()
        {
            this.Name = "Riya";
            this.Marks = 23;
        }

        public void sdetails()
        {
            Console.WriteLine($"Name is {Name} and marks is {Marks}");
        }
    }
}
