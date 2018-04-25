using System;

namespace Exercise_2
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

            Console.Write("\nElements in array in reverse are: ");

            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
