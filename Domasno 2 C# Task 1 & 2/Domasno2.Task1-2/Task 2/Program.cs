#region Student Group

string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[5] { "Vanco", "Pero", "Vane", "Mile", "Cacko" };

Console.WriteLine("Enter 1 if you want the students from group G1, or enter 2 if you want the students from group G2!!!");
bool number = int.TryParse(Console.ReadLine(), out int numberParsed);

if (number)
{
    if (numberParsed == 1)
    {
        Console.WriteLine("The students in the group G1 are: ");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }

    }
    else if (numberParsed == 2)
    {
        Console.WriteLine("The students in the group G2 are: ");
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }
    else
    {
        Console.WriteLine("You must enter 1 or 2,no other numbers!!!");
    }
}
else
{
    Console.WriteLine("Please enter number 1 or number 2,everything else will result in an error!!!");
}



#endregion

