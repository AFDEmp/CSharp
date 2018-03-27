using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            string answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);

            StringBuilder result = new StringBuilder();

            while (num > 1)
            {
                int remainder = num % 2;
                result.Insert(0, remainder);
                num /= 2;
            }

            result.Insert(0, num);
            Console.WriteLine("Binary: {0}", result);
            Console.ReadKey();
        }
    }
}
