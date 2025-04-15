using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Allconceptspractice
{
// Create a Theatre class:
//Property: TheatreName
//Use an array to hold 7 days of ticket availability(bool)
//Use indexer to set ticket status for each day
//Method: IsFull(int dayIndex) → returns true if tickets are sold out
    public class Theater
    {
        public string TheaterName {  get; set; }
        private bool[] TickAvail = new bool[7];

        public bool this[int index] 
        {
            get { return TickAvail[index]; }
            set { TickAvail[index] = value; }
        }

        public Theater(string tn)
        {
            this.TheaterName = tn;
            
        }

        public bool isFull(int dayIndex)
        {
            if (this.TickAvail[dayIndex] == false)
            {
                Console.WriteLine( "Tickets  not available at that day");
                return true;
            }
            else
            {
                Console.WriteLine("Tickets are  available");
                return false;
            }
            
        }
    }
}
