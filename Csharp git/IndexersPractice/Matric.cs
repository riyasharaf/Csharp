using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractice
{
    public class Matric

    {
        private int[,] data = new int[3, 3]; // 3x3 matrix

        public int this[int row, int col]
        {
            get
            {
                return data[row, col];
            }
            set
            {
                data[row, col] = value;
            }
        }

             public void PrintMatrix()
        {
            foreach(int a in data)
            {

                Console.WriteLine(a + " ");
            }
            }
        }
    }
    

