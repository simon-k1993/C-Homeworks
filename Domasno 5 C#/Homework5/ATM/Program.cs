using ATM.Classes3;
using System.Runtime.Intrinsics.X86;

Customer currentCustomer = null;
Customer[] database = new Customer[]
{
    new Customer("Simon", "Kozoloski", new Card(1234123412341234, 100)),
    new Customer("Mile", "Panika", new Card(4321432143214321, 1000)),
    new Customer("Cacko", "Konopishki", new Card(2958154726982156,9500)),
    new Customer("Toso", "Malerot", new Card(3254987462510247,3400))
};

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Press 1 for new user!\n");
    Console.WriteLine("Press 2 for existing user!\n");
    Console.WriteLine("Enter your choice: \n");
    bool userInput1 = int.TryParse(Console.ReadLine(), out int userInputParsed1);
    Console.WriteLine();


    if(!userInput1 || (userInputParsed1 != 1 && userInputParsed1 != 2))
    {
        Console.WriteLine("Wrong input!");
        continue;
    }
    if(userInputParsed1 == 1)
    {
        Console.WriteLine("Enter name!");
        Console.WriteLine();
        string newName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Enter last name!");
        Console.WriteLine();
        string lastName = Console.ReadLine();
        Console.WriteLine();
        long seg1 = new Random().Next(1000, 9999);
        long seg2 = new Random().Next(1000, 9999);
        long seg3 = new Random().Next(1000, 9999);
        long seg4 = new Random().Next(1000, 9999);
        long newNumber = seg1 * 1000000000000 + seg2 * 100000000 + seg3 * 1000 + seg4;

        Customer newCustomer = new Customer(newName, lastName, new Card(newNumber, 0));
        Array.Resize(ref database, database.Length+1);
        database[database.Length-1] = newCustomer;

        continue;
    }
    foreach (Customer customer in database)
    {
        customer.CustomerLibrary();
    }

    Console.WriteLine();
    Console.WriteLine("********Welcome to ATM Service********\n");
    Console.WriteLine("Enter card number in this format: ****-****-****-****\n");
    string cardNumberString = Console.ReadLine();

    string[] cardSegments = cardNumberString.Split('-');
    bool isNumberFormatCorrect = true;

    if (cardSegments.Length == 4)
    {
        foreach (string segment in cardSegments)
        {
            if (segment.Length != 4)
            {
                isNumberFormatCorrect = false;
            }
        }
    }
    else
    {
        isNumberFormatCorrect = false;
    }
    Console.WriteLine();

    string joined = String.Join("", cardSegments);

    bool cardNumber = long.TryParse(joined, out long cardNumberParsed);
    Console.WriteLine();

    bool case4 = true;
    foreach (Customer customer in database)
    {
        if (customer.Card.Number == cardNumberParsed)
            currentCustomer = customer;
    }

    if (cardNumber && isNumberFormatCorrect && currentCustomer != null)
    {
        Console.WriteLine("Enter PIN number\n");
        bool pinNumber = int.TryParse(Console.ReadLine(), out int pinNumberParsed);
        Console.WriteLine();
        if (!pinNumber || currentCustomer.Card.GetCardPin() != pinNumberParsed)
        {
            Console.WriteLine("Enter a valid PIN number!!!");
            return;
        }
        while (true)
        {
            currentCustomer.GetCustomerInfo();

            Console.WriteLine();
            Console.WriteLine("Press 1 to Check Balance\n");
            Console.WriteLine("Press 2 to Withdraw Cash\n");
            Console.WriteLine("Press 3 to Deposit Cash\n");
            Console.WriteLine("Press 4 to Exit\n");
            Console.WriteLine("Enter your choice: \n");
            bool userInput = int.TryParse(Console.ReadLine(), out int userInputParsed);
            Console.WriteLine();

            if (userInput)
            {
                switch (userInputParsed)
                {
                    case 1:
                        Console.WriteLine($"Your balance is: {currentCustomer.Card.GetBalance()} $");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount of money you wish to withdraw: \n");
                        bool moneyWithdrawn = int.TryParse(Console.ReadLine(), out int moneyWithdrawnParsed);

                        if (moneyWithdrawn)
                        {
                            currentCustomer.WithdrawMoney(moneyWithdrawnParsed);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter a valid amount!!!");
                        }
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Enter the amount of money you wish to deposit: ");
                        Console.WriteLine();

                        bool moneyDeposited = int.TryParse(Console.ReadLine(), out int moneyDepositedParsed);

                        if (moneyDeposited && moneyDepositedParsed > 0)
                        {
                            currentCustomer.DepositMoney(moneyDepositedParsed);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter a valid amount!!!");
                        }
                        break;
                    case 4:
                        case4 = false;
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using the ATM app!!!");
                        break;
                }

                if (!case4)
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to continue? If yes press Y/y, if no press N/n !!!");
                string yesOrNo = Console.ReadLine();
                Console.WriteLine();



                if (yesOrNo == "Y" || yesOrNo == "y")
                {
                    continue;
                }
                else if (yesOrNo == "N" || yesOrNo == "n")
                {
                    Console.WriteLine("Thank you for using the ATM app!!!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter Y/y od N/n !!!");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}



