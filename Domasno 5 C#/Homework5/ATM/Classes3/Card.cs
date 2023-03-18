namespace ATM.Classes3
{
    public class Card
    {
        public Card(long cNumber, int balance)
        {
            Number = cNumber;
            Balance = balance;
            Pin = GeneratePin();
        }

        public long Number { get; set; }
        private int Balance { get; set; }
        private int Pin { get; set; }

        private int GeneratePin()
        {
            return new Random().Next(1000, 9999);
        }

        public int GetCardPin()
        {
            return Pin;
        }

        public int GetBalance()
        {
            return Balance;
        }
        public void AddToBalance(int money)
        {
            Balance += money;
        }
        public void SubtractFromBalance(int money)
        {
            Balance -= money;
        }
    }
}

