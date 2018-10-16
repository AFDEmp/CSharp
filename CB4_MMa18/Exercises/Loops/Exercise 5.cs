using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsHomeTM
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 2000; i++)
            {
                if (i % 100 == 0 && i < 1000)
                {
                    Console.WriteLine("{0}", i);
                }

                if (i % 50 == 0 && i >= 1000)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            Console.Write("Enter a number\t");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, result);
            }

            // Nested for loop
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write(j + "  ");
                }
                Console.WriteLine("\t\t" + i);
            }

            //Console.WriteLine("\n\n");
            Console.Write("Enter a number\t");
            int fib = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 3; i <= fib; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine("the req {0} fib  number is {1}", i, b);
            }
            Console.WriteLine(b);

        }
    }
}
