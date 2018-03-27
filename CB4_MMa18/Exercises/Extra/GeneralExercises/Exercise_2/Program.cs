using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the radius of the circle: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("\nPerimeter of circle: {0}", perimeter);
            Console.ReadKey();
        }
    }
}
