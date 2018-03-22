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
            string quote = "Everything you have seen here has been an illusion.";

            // Chaining
            int spaces = quote.Split(' ').Length - 1;
            //Output: 8

            Console.Write("Insert a quote: ");
            string userQuote = Console.ReadLine().Trim();
            int userQuoteSpaces = userQuote.Split(' ').Length;

            // LINQ
            int spacesCount = quote.Count(i => i == ' ');
        }
    }
}
