using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            int length;

            do
            {
                Console.Write("Input the number of elements to store in the array: ");
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out length);

                if (!isValidInput)
                {
                    Console.WriteLine("Please insert an integer...");
                }
            } while (!isValidInput);

            int[] array = new int[length];

            Console.WriteLine($"Input {length} elements in the array:");

            for (int i = 0; i < length; i++)
            {
                int element;

                do
                {
                    Console.Write($"element - {i}: ");
                    string input = Console.ReadLine();
                    isValidInput = int.TryParse(input, out element);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Please insert an integer...");
                    }
                } while (!isValidInput);

                array[i] = element;
            }

            Console.Write("Elements in array are: ");

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
