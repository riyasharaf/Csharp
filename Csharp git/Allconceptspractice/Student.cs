using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Allconceptspractice
{
// Create a Student class with the following properties:
//Name(string)
//Age(int)
//Percentage(float)
//Make sure:
//Age cannot be less than 5.
//Percentage must be between 0 and 100. Use properties to perform validation.If invalid values are set, show an error message.
    public class Student
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 5)
                {
                    Console.WriteLine("Invalid age");
                }
                else
                {
                    age = value;
                }


            }
        }

        private float percentage;
        public float Percentage { get { return percentage; }
            set { 
                if (value < 0 || value > 100)
                {

                    Console.WriteLine("invalid percentage");

                }
                else { 
                    percentage = value;
                     }
            }
        }

        public Student(string name , int age , float percentage)
        {
            this.Name = name;   
            this.Age = age;
            this.Percentage = percentage;
        }


        public void showdet()
        {
            Console.WriteLine($"Name is {Name} age is {age} percentage is {percentage}");
        }


    }
}
