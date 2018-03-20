using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Circle
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Sum
        {
            get
            {
                return X + Y;
            }
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
