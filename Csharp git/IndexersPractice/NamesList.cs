using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractice
{
    public class NamesList
    {

        public string[] names = new string[5];
        //Create a class NamesList where you can get the index of a name using a string-based indexer.




        public int this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {

                    if (name == names[i])
                    {
                        return i;
                    }

                }
                return -1;
            }
            
        }
        }
    }