namespace law_of_demeter
{
    public class Wallet {
        public decimal Amount { get; set; }
        private bool isActivated;

        public Wallet() {
            isActivated = false;
        }

        public void Activate() {
            isActivated = true;
        }

        public bool IsActivated() {
            return isActivated;
        }
    }
}