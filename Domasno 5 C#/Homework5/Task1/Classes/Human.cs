namespace Task1.Classes
{
    public class Human
    {

        public Human(string firstName,string lastName,int age)
        {
            FirstName=firstName;
            LastName=lastName;
            Age=age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } = 1;

        public void GetPersonDetails()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"The person you entered is: {FirstName} {LastName} {Age}");
            Console.ResetColor();
        }
    }
}
