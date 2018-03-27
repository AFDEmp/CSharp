using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the radius of the circle: ");
            double r = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * (r * r);
            double volume = 4.0 / 3.0 * Math.PI * (r * r * r);
            Console.WriteLine("\nSurface of circle: {0}", surface);
            Console.WriteLine("\nVolume of circle: {0}", volume);
            Console.ReadKey();
        }
    }
}
