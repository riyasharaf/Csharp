using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practiceforobjectandclasses
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }

        public Customer(string name , string address , string phonenum)
        {
            Name = name;
            Address = address;
            PhoneNum = phonenum;

            Console.WriteLine($"{name} {address} {phonenum}");
            
        }

        //methods
        public void setdetails(string name , string address , string phonenum)
        {
            Name = name;
            Address = address;
            PhoneNum = phonenum;
            Console.WriteLine($"{name} {address} {phonenum}");
        }

        public Customer(string name)
        {
            Name = name;
            Console.WriteLine(name);
        }
        //Default Constructor in Csharp.
        public Customer()
        {
            Name = Name;
            Address = Address;
            PhoneNum = PhoneNum;
           

        }
    }
}
