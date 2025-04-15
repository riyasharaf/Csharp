using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractice
{

    //Create a BookShelf class that stores book names.
    //Overload the indexer:
    // this[int index] – returns the book name at the index.
    //this[string name] – returns the index of the book.


    internal class BookShelf
    {
        public string[] Bname = new string[3] { "a", "b", "c" };

        public string this[int index]
        {
            get
            {
                return Bname[index];
            }
            set
            {
                Bname[index] = value;
            }
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < Bname.Length; i++)
                {

                    if (Bname[i] == name)
                    {
                        return i;
                    }

                }
                return -1;
            }



        }
    }
}
