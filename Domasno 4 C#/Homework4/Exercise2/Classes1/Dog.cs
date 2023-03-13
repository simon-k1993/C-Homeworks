using System.ComponentModel;

namespace Exercise2.Classes1
{
    public class Dog
    {
        public Dog(string name,string race,string color) 
        { 
            Name = name;
            Race = race;
            Color = color;
        }

        public string Name { get; set; }    
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eat() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{Name} the {Color} {Race} is now eating!");
            Console.ResetColor();
        }

        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{Name} the {Color} {Race} is now playing!");
            Console.ResetColor();
        }

        public void ChaseTail()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{Name} the {Color} {Race} is now chasing its tail!");
            Console.ResetColor();
        }
    }
}
