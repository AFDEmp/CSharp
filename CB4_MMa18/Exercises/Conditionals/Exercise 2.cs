using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {

//First lab.

            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            bool boolean1 = false;
            bool boolean2 = false;

            if (boolean1 && boolean2)
            {
                Console.WriteLine("Both bools are true.");
            }
            if (!boolean1 && !boolean2)
            {
                Console.Write("Both bools are false...");
                Console.WriteLine("Addition -> Result:{0}", number1 + number2);
            }
            if (!boolean1 || !boolean2)
            {
                Console.Write("At least one bool is false...");
                Console.WriteLine("Subtraction -> Result:{0}", number1 - number2);
            }
            if ( !boolean1 && number1 > 15 )
            {
                Console.Write("First bool is false and first number > 15...");
                Console.WriteLine("Multiplication -> Result:{0}", number1 * number2);
            }
            else
            {
                Console.WriteLine("First bool is true or first number is <= 15");
            }
            if ( boolean2 && number1 + number2 > 63 && number1 % number2 == 0 )
            {
                Console.WriteLine("Bool2 is TRUE, Addition is over  63 and num1%num2 is 0");
            }
            else
            {
                Console.WriteLine("Bool2 is FALSE OR Addition is <= 63 OR num1%num2 is NOT 0");
            }
        }
    }
}
