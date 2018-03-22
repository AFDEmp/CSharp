using System;
using System.Text;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a string: ");
            string input = Console.ReadLine().Trim();
            Console.WriteLine(SubstringSearch(input));
            Console.ReadKey();
        }

        static string SubstringSearch(string str)
        {
            StringBuilder result = new StringBuilder();
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                char symbol = str[i];
                if (symbol == str[length - i - 1])
                {
                    result.Append(symbol);
                }
                else
                {
                    break;
                }
            }
            return result.ToString();
        }
    }
}
