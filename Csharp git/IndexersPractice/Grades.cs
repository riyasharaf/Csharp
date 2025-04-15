using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IndexersPractice
{

    //    Create a class Grades with subjects and marks.
    //Use string indexer to get/set marks by subject name.
    //Example: grades["Math"] = 90; or Console.WriteLine(grades["Science"]);
    internal class Grades
    {
        public string[] Subjects = new string[3] { "Maths", "Science", "English" };
        public int[] marks = new int[3] { 67, 78, 98 };

        public int this[string sub]
        {
            get
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Subjects[i] == sub)
                    {
                        return marks[i];
                    }
                }
                return -1;
            }

            set
            {
                for (int i = 0; i < 3; i++) 
                {
                    if (Subjects[i] == sub)
                    {
                        marks[i] = value;
                        return;
                    }
                
                }
            }

        }

    }
}
