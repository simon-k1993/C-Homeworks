List<int> numbers = new List<int>();

numbers.Add(3);
numbers.Add(2);
numbers.Add(15);
numbers.Add(12);
numbers.Add(9);
numbers.Add(7);

List<int> squaredNumbers = numbers.Select(x => x * x).ToList();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Squared numbers in the list: ");
Console.ResetColor();
foreach (int number in squaredNumbers)
{
    Console.WriteLine(number);
}
