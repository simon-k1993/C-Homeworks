#region SumOfEven


Console.WriteLine("Enter number one");
bool isNumber1Parse = int.TryParse(Console.ReadLine(), out int number1Parsed);

Console.WriteLine("Enter number two");
bool isNumber2Parse = int.TryParse(Console.ReadLine(), out int number2Parsed);

Console.WriteLine("Enter number three");
bool isNumber3Parse = int.TryParse(Console.ReadLine(), out int number3Parsed);

Console.WriteLine("Enter number four");
bool isNumber4Parse = int.TryParse(Console.ReadLine(), out int number4Parsed);

Console.WriteLine("Enter number five");
bool isNumber5Parse = int.TryParse(Console.ReadLine(), out int number5Parsed);

Console.WriteLine("Enter number six");
bool isNumber6Parse = int.TryParse(Console.ReadLine(), out int number6Parsed);

int[] arrayOfNumbers = new int[6];

arrayOfNumbers[0] = number1Parsed;
arrayOfNumbers[1] = number2Parsed;
arrayOfNumbers[2] = number3Parsed;
arrayOfNumbers[3] = number4Parsed;
arrayOfNumbers[4] = number5Parsed;
arrayOfNumbers[5] = number6Parsed;

int sum = 0;

foreach (int number in arrayOfNumbers)
{

    if (number % 2 == 0)
    {
        sum += number;
    }
}
Console.WriteLine("The sum of the even numbers in the array is: " + sum);


#endregion