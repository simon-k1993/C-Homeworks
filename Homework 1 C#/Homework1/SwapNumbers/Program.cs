#region Exercise 3


Console.WriteLine("Enter the first number");
bool numberUnoParse = int.TryParse(Console.ReadLine(), out int parsedNumberUno);

Console.WriteLine("Enter the second number");
bool numberDuoParse = int.TryParse(Console.ReadLine(), out int parsedNumberDuo);

if(numberUnoParse && numberDuoParse)
{
    var helperVariable = parsedNumberUno;
    parsedNumberUno = parsedNumberDuo;
    parsedNumberDuo = helperVariable;

    Console.WriteLine("The value of First Number after swapping his value is: " + parsedNumberUno);
    Console.WriteLine("The value of Second Number after swapping his value is: " + parsedNumberDuo);

}
else
{
    Console.WriteLine("Enter numbers! Invalid input!");
}



#endregion