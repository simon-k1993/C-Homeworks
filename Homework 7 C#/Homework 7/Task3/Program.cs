using ClassLibrary.Classes;
using ClassLibrary.Enums;

List<Animal> animals = new List<Animal>();

animals.Add(new Animal("Dog","brown",5,Gender.male));
animals.Add(new Animal("Cat", "white", 2, Gender.female));
animals.Add(new Animal("Elephant", "grey", 12, Gender.male));
animals.Add(new Animal("Parrot", "red", 2, Gender.male));
animals.Add(new Animal("Python", "green", 15, Gender.female));
animals.Add(new Animal("Rabbit", "brown", 3, Gender.male));
animals.Add(new Animal("Tiger", "Orange", 16, Gender.male));
animals.Add(new Animal("Shrewmouse", "black", 1, Gender.male));
animals.Add(new Animal("Chimpanzee", "brown", 5, Gender.female));
animals.Add(new Animal("Alpaca", "brown", 3, Gender.male));

List<Animal> animalsAgeFiveOrMore = animals.Where(x =>x.Age >= 5).ToList();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Animals aged 5 or older: ");
Console.ResetColor();
Console.WriteLine();
foreach(Animal animal in animalsAgeFiveOrMore)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine();
List<Animal> animalsWithFirstLetterA = animals.Where(x=>x.Name.StartsWith("A")).ToList();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Animals with first letter A: ");
Console.ResetColor();
Console.WriteLine();
foreach(Animal animal in animalsWithFirstLetterA)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine();
List<Animal> allMaleBrownAnimals = animals.Where(x=>x.Color == "brown").Where(x=>x.Gender == Gender.male).ToList();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("All male brown animals: ");
Console.ResetColor();
Console.WriteLine();
foreach(Animal animal in allMaleBrownAnimals)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine();
List<Animal> animalsWithNamesLongerThan10 = animals.Where(x=>x.Name.Length >= 10).ToList();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Animals with names longer than 10 characters: ");
Console.ResetColor();
Console.WriteLine();
foreach(Animal animal in animalsWithNamesLongerThan10)
{
    Console.WriteLine(animal.Name);
}