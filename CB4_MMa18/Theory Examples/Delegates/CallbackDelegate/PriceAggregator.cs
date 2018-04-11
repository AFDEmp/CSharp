using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackDelegate
{
    /// <summary>
    /// Class to total and average prices of books.
    /// </summary>
    public class PriceAggregator
    {
        private int _books = 0;
        private decimal _totalPrice = 0.0m;

        internal void AddBookToTotal(Book book)
        {
            _books += 1;
            _totalPrice += book.Price;
        }

        public decimal AveragePrice()
        {
            return _totalPrice / _books;
        }
    }
}
