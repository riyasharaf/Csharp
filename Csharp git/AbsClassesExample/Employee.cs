using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsClassesExample
{
    //Create an abstract class Employee with a method CalculateSalary() and implement it in FullTimeEmployee and PartTimeEmployee.
    public abstract class Employee
    {
        public abstract double CalcualteSal();

    }

    public class FulltimeEmployee : Employee
    {
        public double Sal {  get; set; }
        public int hours { get; set; }

        public FulltimeEmployee(double sal , int hours)
        {
            this.Sal = sal;
            this.hours = hours;

        }
        public override double CalcualteSal()
        {
            return Sal * hours;
        }
    }

    public class ParttimeEmployee : Employee
    {
        public double Sal { get; set; }
        public int hours { get; set; }

        public ParttimeEmployee(double sal, int hours)
        {
            this.Sal = sal;
            this.hours = hours;

        }
        public override double CalcualteSal()
        {
            return Sal * hours;
        }
    }






}
