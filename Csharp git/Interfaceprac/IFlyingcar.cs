using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceprac
{
    //Create two interfaces IDrive and IFly.Now create a class FlyingCar that implements both.

    interface IDrive
    {
        void drive(string car);
    }

    interface IFly
    {
        void fly(string airplane);
    }
    public class IFlyingcar :IDrive, IFly
    {
        public void drive(string car)
        {
            Console.WriteLine(car);
        }
        public void fly(string airplane)
        {
            Console.WriteLine(airplane);
        }

    }
}
