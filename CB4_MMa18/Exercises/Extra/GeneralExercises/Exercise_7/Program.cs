using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=y²-2y+1\n");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y - 2 * y + 1;
                Console.Write($"y={y} ; x={y}²-2({y})+1={x}\n");
            }

            Console.ReadKey();
        }
    }
}
