using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Circle
{
    class Circle
    {
        public double Radius { get; private set; }
        public Point Center { get; private set; }
        public Color Fill { get; private set; }
        public Color Border { get; private set; }

        // Property Area is read-only
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public Circle()
        {
            Radius = 1.0;
            Fill = new Color(255, 0, 0);
            Border = new Color(255, 0, 0);
            Center = new Point(0, 0);
        }

        public Circle(double r, Point center, Color fill, Color border)
        {
            Radius = r;
            Center = center;
            Fill = fill;
            Border = border;
        }

        public void SetFillColor(Color fill)
        {
            Fill = fill;
        }

        public void SetFillColor(int r, int g, int b)
        {
            Fill = new Color(r, g, b);
        }

        public void SetBorderColor(Color border)
        {
            Border = border;
        }

        public void SetBorderColor(int r, int g, int b)
        {
            Border = new Color(r, g, b);
        }

        public void SetRadius(double v)
        {
            Radius = v;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        
        public bool IsPointInCircle(Point p)
        {
            double d = Math.Sqrt(Math.Pow(p.X - Center.X, 2) + Math.Pow(p.Y - Center.Y, 2));
            if (d <= Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
