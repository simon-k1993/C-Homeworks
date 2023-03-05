#region Exercise 2


Console.WriteLine("Enter the first of four numbers");
bool numberOne = int.TryParse(Console.ReadLine(), out int parsedNumberOne);

Console.WriteLine("Enter the second of four numbers");
bool numberTwo = int.TryParse(Console.ReadLine(), out int parsedNumberTwo);

Console.WriteLine("Enter the third of four numbers");
bool numberThree = int.TryParse(Console.ReadLine(), out int parsedNumberThree);

Console.WriteLine("Enter the fourth of four numbers");
bool numberFour = int.TryParse(Console.ReadLine(), out int parsedNumberFour);

if (numberOne && numberTwo && numberThree && numberThree)
{
    Console.WriteLine("The average of the four numbers inputed is: " + (parsedNumberOne + parsedNumberTwo + parsedNumberThree + parsedNumberFour) / 4);
}
else
{
    Console.WriteLine("Enter numbers! Invalid input!");
}

#endregion