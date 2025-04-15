using System;

namespace IndexersPractice
{


    //Create a class MyArray with an integer array and define an indexer to get/set values using an integer index.

    public class Myarray
    {
        public int[] numbers = new int[5];

        public int this[int index]
        {
            get {

                return numbers[index];
                    
            }

            set {
                
                numbers[index] = value;
            
            }
                
                }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Myarray n1 = new Myarray();
            //n1[0] = 2;
            //n1[1] = 3;

            //for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine(n1.numbers[i]);
            //}


            //NamesList n2 = new NamesList();
            //n2.names[1] = "Riya";
            //Console.WriteLine(n2["Riya"]);

            //Student s1 = new Student();
            //s1.Snames = new string[] { "Riya", "Rinal", "Prashant", "Rinal", "Aditi" };
            //s1.rollno = new string[] {"1","2" , "3" ,"4" ,  "5"};
            //Console.WriteLine(s1["5"]);

            //DaysOfWeek a = new DaysOfWeek();
            //a[0] = "Monday";
            //a[1] = "Tuesday";
            //a[2] = "Wednesday";
            //a[3] = "Thursday";
            //a[4] = "Friday";

            //Console.WriteLine(a[2]);
            //Console.Read();

            //BookShelf b = new BookShelf();
            //b[0] = "abcdefghijkl";

            //Grades a = new Grades();
            //a["Maths"] = 90;
            //Console.WriteLine(a["Maths"]);


            Matric m = new Matric();
            m[1, 2] = 90;
            m[0, 0] = 21;

            

            m.PrintMatrix();
            //Console.WriteLine(b[0]);

            Console.Read();
        }
    }
}
