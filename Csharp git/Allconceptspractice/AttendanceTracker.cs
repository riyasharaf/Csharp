using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Allconceptspractice
{

    //You are building a simple attendance tracker.Create a class AttendanceTracker that keeps track of attendance for 7 days 
    // using an internal array of booleans.Implement an indexer so you can access attendance like:
    public class AttendanceTracker
    {
        public bool[] attentrac = new bool[7] {true, false , true, true, true, true, false};
        public bool this[int index]
        {
            get { return attentrac[index]; }

            set { attentrac[(int)index] = value;}
        }

        public void ShowWeeklyAttendance()
        {
            for (int i = 0; i < attentrac.Length; i++)
            {
                string status = attentrac[i] ? "Present" : "Absent";
                Console.WriteLine($"Day {i + 1}: {status}");
            }
        }



    }
}
