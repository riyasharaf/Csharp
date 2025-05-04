using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static DelegatesPractice.Calc;
using static DelegatesPractice.multicast;
using static DelegatesPractice.Prac;
using static DelegatesPractice.Program;

namespace DelegatesPractice
{
    //Create a delegate called Operation that takes two integers and returns an integer.
    //Use an anonymous method to assign logic for addition, and then invoke it.

    public delegate int Operation(int x, int y);
    public delegate void Abc(string message);
    internal class Operationss
    {
       
    }
}
