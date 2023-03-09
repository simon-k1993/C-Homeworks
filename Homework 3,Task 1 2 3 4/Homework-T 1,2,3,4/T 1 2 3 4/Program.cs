#region Task 1

Console.WriteLine("Write down a string");
string someString = Console.ReadLine();

Console.WriteLine("");

string newString = someString.Substring(someString.Length - 5);
Console.WriteLine($"The last five characters of this strings are: {newString} ");

#endregion
Console.WriteLine("");
#region Task 2

Console.WriteLine("Enter a sentence");
string sentence = Console.ReadLine();

Console.WriteLine("");

string[] words = sentence.Split();

Console.WriteLine("This sentence has this words: ");

for (int i = 0; i < words.Length; i++)
{

    Console.WriteLine(words[i]);
}

#endregion
Console.WriteLine("");
#region Task 3

Console.WriteLine("Enter a big number");
string number = Console.ReadLine();

Console.WriteLine("");

int sum = 0;
char[] charNumber = number.ToCharArray();

for (int i = 0; i < charNumber.Length; i++)
{
    sum += int.Parse(charNumber[i].ToString());

}
Console.WriteLine($"The sum of the digits from the entered number is: {sum}");

#endregion
Console.WriteLine("");
#region Task 4

Console.WriteLine("Enter your date of birth in this format: mm/dd/yyyy");
string dateOfBirth = Console.ReadLine();

Console.WriteLine("");

if (dateOfBirth.Length != 10)
{
    Console.WriteLine("Please write 2 numbers for month than add / 2 numbers for days than add / and 4 numbers for year!!!");
}
else
{
    DateTime convertedDateOfBirth = Convert.ToDateTime(dateOfBirth);

    Console.WriteLine("");

    Console.WriteLine($"Your date of birth is: {convertedDateOfBirth}");

    Console.WriteLine("");

    DateTime dateTime = DateTime.Now;
    Console.WriteLine($"Today date is: {dateTime}");

    Console.WriteLine("");

    int age = dateTime.Year - convertedDateOfBirth.Year;



    if (dateTime.Month < convertedDateOfBirth.Month || (dateTime.Month == convertedDateOfBirth.Month && dateTime.Day < convertedDateOfBirth.Day))
        age--;

    Console.WriteLine($"You are: {age} years old");
}

#endregion