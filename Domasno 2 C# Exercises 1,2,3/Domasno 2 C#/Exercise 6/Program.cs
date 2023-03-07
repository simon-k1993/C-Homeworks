#region Array with Names


string[] arrayWithNames = new string[1];


int num = 0;



for (int i = 0; i <= arrayWithNames.Length; i++)
{


    Console.WriteLine("Please enter a name");
    string name = Console.ReadLine();


    Array.Resize(ref arrayWithNames, arrayWithNames.Length + i);
    arrayWithNames[i] = name;

    Console.WriteLine("If you want to continue enter Y for yes, or enter N for no!!!");
    string yesOrNo = Console.ReadLine();


    if (yesOrNo == "Y")
    {

        num++;

        continue;
    }
    else if (yesOrNo == "N")
    {
        Console.WriteLine("The names in the array are: ");

        for (int j = 0; j <= num; j++)
        {


            Console.WriteLine(arrayWithNames[j]);

        }
        break;
    }
    else
    {
        Console.WriteLine("Please enter Y od N, everything else will result in an ERROR!!!");
        break;
    }
}






#endregion