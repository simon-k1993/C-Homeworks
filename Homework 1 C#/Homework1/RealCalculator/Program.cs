#region Exercise 1

Console.WriteLine("Enter the first number");
bool number1Parse = int.TryParse(Console.ReadLine(), out int parsedNumber1);


Console.WriteLine("Enter the second number");
bool number2Parse = int.TryParse(Console.ReadLine(), out int parsedNumber2);


Console.WriteLine("Enter the operation");
bool operationParsed = char.TryParse(Console.ReadLine(), out char parsedOperation);

if (number1Parse && number2Parse && operationParsed)
{
    if (parsedOperation == '+')
    {
        Console.WriteLine("The result for summing the two numbers is " + (parsedNumber1 + parsedNumber2));
    }
    else if (parsedOperation == '-')
    {
        Console.WriteLine("The result for subtracting the two numbers is " + (parsedNumber1 - parsedNumber2));
    }
    else if (parsedOperation == '*')
    {
        Console.WriteLine("The result for multiplicating the two numbers is " + (parsedNumber1 * parsedNumber2));
    }
    else if (parsedOperation == '/')
    {
        Console.WriteLine("The result for dividing the two numbers is " + (parsedNumber1 / parsedNumber2));
    }
    else
    {
        Console.WriteLine("Please enter Numbers and a valid operation");
    }



}
else
{
    Console.WriteLine("Please enter Numbers and a valid operation");
}


#endregion