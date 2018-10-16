using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsTM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use a number from user to create while and Do Wlile loops
            Console.WriteLine("Give me a Number: ");
            int number = int.Parse(Console.ReadLine());

            //while ( number > 0 )
            //{
            //    Console.WriteLine("Hello");
            //    //number = number - 1;
            //    number--;
            //}

            do
            {
                Console.WriteLine("Bye");
                number--;
            } while (number > 0);

            Console.WriteLine("Out of the loop");
        }
    }
}
