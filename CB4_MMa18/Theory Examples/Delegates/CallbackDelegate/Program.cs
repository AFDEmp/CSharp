using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackDelegate
{
    class Program
    {
        static void PrintBookTitle(Book book)
        {
            Console.WriteLine($"{book.Title}");
        }

        static void AddBooks(BooksCollection booksCollection)
        {
            booksCollection.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            booksCollection.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            booksCollection.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
            booksCollection.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
        }

        static void Main(string[] args)
        {
            BooksCollection booksCollection = new BooksCollection();
            AddBooks(booksCollection);
            Console.WriteLine("Paperback Book Titles:");
            booksCollection.ProcessPaperbackBooks(PrintBookTitle);

            PriceAggregator aggregator = new PriceAggregator();
            booksCollection.ProcessPaperbackBooks(aggregator.AddBookToTotal);

            Console.WriteLine("Average Paperback Book Price: ${0:#.##}", aggregator.AveragePrice());

            Console.ReadKey();
        }
    }
}
