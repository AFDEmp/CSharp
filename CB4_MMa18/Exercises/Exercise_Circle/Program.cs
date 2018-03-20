using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            //Console.WriteLine($"radius: {c.Radius}, center: ({c.Center.X},{c.Center.Y}), Fill: {c.Fill}");

            Point p = new Point(5, 2);
            //Console.WriteLine(p.Sum);

            Color red = new Color(255, 0, 0);
            c.SetFillColor(red);
            c.SetFillColor(new Color(0, 0, 0));
            c.SetFillColor(0, 0, 0);


            Console.WriteLine($"Is point ({p.X},{p.Y}) in circle?: {c.IsPointInCircle(p)}");
            
            c.SetRadius(10);
            
            Console.WriteLine($"Is point ({p.X},{p.Y}) in circle?: {c.IsPointInCircle(p)}");

            Console.ReadKey();
        }
    }
}
