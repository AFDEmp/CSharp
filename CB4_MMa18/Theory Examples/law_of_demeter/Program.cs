using System;

namespace law_of_demeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Mitsos");
            // The following line does not obey the Law of Demeter
            //decimal amount = customer.Wallet.Amount
            // We should encapsulate the functionality to avoid null reference
            decimal amount = customer.GetWalletAmount();
            Console.WriteLine($"Amount is {amount}");
        }
    }
}
