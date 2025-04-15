using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Allconceptspractice
{
    //    Design a Student class with :
    //Properties: Name, RollNumber, Marks[] (for 5 subjects)
    //Use an indexer to access marks like student[0] = 80;
    //    Method: GetAverageMarks()
    //Display student details and their average.

    public class Student1
    {

        public string Name { get; set; }
        public int Rollno { get; set; }
        private int[] Marks = new int[3];

        public int this[int index]
            {
            get
            {
                return Marks[index];
            }
            set
            {
                Marks[index] = value;
            }
            }
        public Student1(string name , int rollno)
        {
            this.Name = name;
            this.Rollno = rollno;   
        }

        public void getstudentdeatisl()
        {
            Console.WriteLine($"Name is {Name} and Rollno is {Rollno}");
            int result = Marks[0] + Marks[1] + Marks[2];
            double average  = result / 3;
            Console.WriteLine($"Average is {average}");
        }



    }
}
