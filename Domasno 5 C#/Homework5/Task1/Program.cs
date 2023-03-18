using Task1.Classes;

Console.WriteLine("Enter first name"); ;
string firstName = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("Enter last name");
string lastName = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("Enter age");
bool ifAgeParsed = int.TryParse(Console.ReadLine(), out int ageParsed);

Console.WriteLine("");

if (ifAgeParsed)
{

    Human human = new Human(firstName, lastName, ageParsed);
    human.GetPersonDetails();

}else
{
    Console.WriteLine("Enter valid age!");
};