namespace ATM.Classes3
{
   public class Customer
    {
        public Customer(string firstname, string lastname, Card creditCard)
        {
            Firstname = firstname;
            Lastname = lastname;
            Card = creditCard;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Card Card { get; set; }

        public void GetCustomerInfo()
        {
            Console.WriteLine($"Welcome {Firstname} {Lastname}: Your credit card number is: {Card.Number} Your PIN number is: {Card.GetCardPin()} Your balance is: {Card.GetBalance()}$");
        }

        public void CustomerLibrary()
        {
            Console.WriteLine($"[{Firstname} {Lastname}]: Number: {Card.Number} PIN: {Card.GetCardPin()}");
        }

        public void WithdrawMoney(int money)
        {
            if (money <= Card.GetBalance() && money > 0)
            {
                Card.SubtractFromBalance(money);
                Console.WriteLine();
                Console.WriteLine($"You have succesfully withdrawn: {money} $\n");
                
                Console.WriteLine($"New Balance after withdraw: {Card.GetBalance()} $\n");
            }
            else
            {
                Console.WriteLine("You either entered more money than you have in your bank balance OR you have entered a negative number!!!");
            }
        }

        public void DepositMoney(int money)
        {
            
            Console.WriteLine();
            Card.AddToBalance(money);

            Console.WriteLine($"New balance after deposit: {Card.GetBalance()} $\n");
        }
    }

    
}

