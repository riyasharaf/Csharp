using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IndexersPractice
{
    public class Student
    {

        //Create a class Student that stores student names and allows access using roll number through a string indexer.
        //Use a string array for roll numbers and names.

        public string[] Snames = new string[10];
        public string[] rollno = new string[10];

        public string this[string RN]
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {

                    if (RN == rollno[i])
                    {
                        return Snames[i];
                    }


                }
                return "NF";


            }
        }
    }
}
        
