Queue<int> queue = new Queue<int>();

while (true)
{
    Console.WriteLine("Enter a number!");
    bool numberInput = int.TryParse(Console.ReadLine(), out int numberInputParsed);

    if (numberInput)
    {
        queue.Enqueue(numberInputParsed);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Do you want to continue? If yes input Y/y, if no input N/n");
        Console.ResetColor();
        string yesOrNo = Console.ReadLine();

        if (yesOrNo == "Y" || yesOrNo == "y")
        {
            continue;
        }
        else if (yesOrNo == "N" || yesOrNo == "n")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Numbers in the queue: ");
            Console.ResetColor();
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You must enter Y/y or N/n!!!");
            Console.ResetColor();
            break;
        }

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter a number!!!");
        Console.ResetColor();
        break;
    }

}