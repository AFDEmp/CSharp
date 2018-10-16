using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsTM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Standard Loop
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("i = {0}", i);
            }

            // postfix and prefix operator. Examine the differences
            int age = 35;
            int newAge = ++age;
            Console.WriteLine("age = {0}, newAge = {1}", age, newAge);
            newAge = age++;
            Console.WriteLine("age = {0}, newAge = {1}", age, newAge);


            // A different loop. Examine how continue and break works
            int j = 0;
            for (;;)
            {
                Console.WriteLine("Hi!");
                j++;
                if (j == 3)
                {
                    continue;
                }

                Console.WriteLine("j = {0}", j);

                if (j > 5)
                {
                    break;
                }
            }

        }
    }
}
