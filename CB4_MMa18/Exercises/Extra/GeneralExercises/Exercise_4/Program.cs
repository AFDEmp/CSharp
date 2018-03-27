using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || 
                (symbol == 'e') || 
                (symbol == 'i') || 
                (symbol == 'o') || 
                (symbol == 'u') || 
                (symbol == 'y'))
            {
                Console.Write("\nIt's a lowercase vowel.");
            }
            else if((symbol >= '0') && (symbol <= '9'))
            {
                Console.Write("\nIt's a digit.");
            }
            else
            {
                Console.Write("\nIt's another symbol.");
            }

        }
    }
}
