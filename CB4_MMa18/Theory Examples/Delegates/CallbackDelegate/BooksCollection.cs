using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackDelegate
{
    public delegate void ProcessBookDelegate(Book book);
    public class BooksCollection
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            _books.Add(new Book
            {
                Title = title,
                Author = author,
                Price = price,
                Paperback = paperBack
            });
        }

        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            foreach (var book in _books)
            {
                if (book.Paperback)
                    processBook(book);
            }
        }
    }
}
