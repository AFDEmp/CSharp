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

            int[] array2 = new int[length];

            Console.Write("\nElements copied in the second array are: ");
            // Copy
            for (int i = 0; i < length; i++)
            {
                
                array2[i] = array[i];
                Console.Write($"{array2[i]} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
