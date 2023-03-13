using Exercise2.Classes1;

Console.WriteLine("Enter the dog's name");
string name=Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("Enter the dog's race");
string race = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("Enter the dog's color");
string color = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("Enter 1 if you want the dog to Eat, 2 if you want the dog to Play, or 3 if you want the dog to Chase it's tail!!!");
bool ifActionParsed = int.TryParse(Console.ReadLine(), out int actionParsed);


if(ifActionParsed && actionParsed==1) { 

Dog dog = new Dog(name,race,color);
    dog.Eat();
}else if(ifActionParsed && actionParsed==2)
{
    Dog dog = new Dog(name, race, color);
    dog.Play();
}else if (ifActionParsed && actionParsed == 3)
{
    Dog dog = new Dog(name, race, color);
    dog.ChaseTail();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Please enter a number between 1 and 3");
    Console.ResetColor();
}