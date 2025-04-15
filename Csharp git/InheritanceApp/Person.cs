using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    public class Person
    {
        public String Name { get; private set; }
        public int Age { get; private set; }


        public Person(string name , int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person Constructor is Called!!");
        }

        public void displayinfo()
        {
            Console.WriteLine($" Name is {Name} and Age is {Age}");
        }
    }


    public class Employee : Person
    {
        public Employee(string name, int age) : base(name, age);
        {
              Console.WriteLine("Employee Constructor Called!!");
        }
}

   
}
