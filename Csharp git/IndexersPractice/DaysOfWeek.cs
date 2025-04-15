using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractice
{

    //Create a class DaysOfWeek that maps day numbers (0 to 6) to day names using an indexer.

    //Example: days[0] returns "Sunday", days[1] returns "Monday".

    public class DaysOfWeek
    {
        public string[] Days = new string[10];
        public string this[int index]

        {
            get
            {

                return Days[index];
            }

            set
            {
                Days[index] = value;
            }


        }

    }
}




 
