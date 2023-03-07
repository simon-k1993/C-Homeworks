#region Exercise 2 Sum of numbers in an Array

Console.WriteLine("Enter the first of five array elements");
bool number1 = int.TryParse(Console.ReadLine(), out int parsedNumberOne);

Console.WriteLine("Enter the second of five array elements");
bool number2 = int.TryParse(Console.ReadLine(), out int parsedNumberTwo);

Console.WriteLine("Enter the third of five array elements");
bool number3 = int.TryParse(Console.ReadLine(), out int parsedNumberThree);

Console.WriteLine("Enter the fourth of five array elements");
bool number4 = int.TryParse(Console.ReadLine(), out int parsedNumberFour);

Console.WriteLine("Enter the first of four numbers");
bool number5 = int.TryParse(Console.ReadLine(), out int parsedNumberFive);


int[] arrayOfNumbers = new int[5];

arrayOfNumbers[0] = parsedNumberOne;
arrayOfNumbers[1] = parsedNumberTwo;
arrayOfNumbers[2] = parsedNumberThree;
arrayOfNumbers[3] = parsedNumberFour;
arrayOfNumbers[4] = parsedNumberFive;

int sum = 0;

foreach (int number in arrayOfNumbers)
{
    sum += number;
}
Console.WriteLine("The sum of the numbers inputed in the array is: " + sum);

#endregion

