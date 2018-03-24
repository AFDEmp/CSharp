namespace law_of_demeter
{
    public class Customer {
        public string Name { get; set; }
        public Wallet Wallet { get; set; }

        public Customer(string name) {
            Name = name;
        }

        public decimal GetWalletAmount()
        {
            if (Wallet == null) {
                return 0;
            }
            return Wallet.Amount;
        }

        public void DemeterMethod(Wallet w)
        {
            // According to Law of Demeter a method M of object O can call:
            // 1. Methods of Object O itself
            decimal amount = GetWalletAmount();
            // 2. Methods of Object passed as argument
            bool active = w.IsActivated();
            // 3. Methods of object, which is held in instance variable
            Wallet.Activate();
            // 4. Methods of any Object which is created locally in method M
            Wallet myWallet = new Wallet();
            myWallet.Activate();
        }
    }
}