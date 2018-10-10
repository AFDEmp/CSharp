using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            int leftSum = 0;
            int rightSum = 0;
            int size;

            do
            {
                Console.Write("Input the size of the square matrix: ");
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out size);

                if (!isValidInput)
                {
                    Console.WriteLine("Please insert an integer...");
                }
            } while (!isValidInput);

            int[,] matrix = new int[size, size];

            Console.WriteLine($"Input elements in the matrix:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int element;

                    do
                    {
                        Console.Write($"element - [{i},{j}]: ");
                        string input = Console.ReadLine();
                        isValidInput = int.TryParse(input, out element);

                        if (!isValidInput)
                        {
                            Console.WriteLine("Please insert an integer...");
                        }
                    } while (!isValidInput);

                    matrix[i, j] = element;
                }
            }

            Console.Write("The matrix is: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
            }

            Console.WriteLine();



            for (int i = 0; i < size; i++)
            {
                leftSum += matrix[i, i];
                rightSum += matrix[i, size - 1 - i];
            }

            Console.WriteLine($"Sum of the left diagonal elements is: {leftSum}");
            Console.WriteLine($"Sum of the right diagonal elements is: {rightSum}");



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
