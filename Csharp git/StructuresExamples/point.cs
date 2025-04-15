using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExamples
{
    //Create a Point2D struct representing X and Y coordinates.
    // Add a method DistanceTo(Point2D other) that calculates the Euclidean distance to another point.

    struct Point2D
    {
        public int X;
        public int Y;

        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double DistanceTo(Point2D p)
        {
            double a = p.X - this.X;
            double b = p.Y - this.Y;
            return Math.Sqrt(a * a + b * b);
        }
        internal class point
        {
        }
    }
}
