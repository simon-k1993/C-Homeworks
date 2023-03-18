using System.Diagnostics.CodeAnalysis;

namespace Task_2.Classes1
{
    public class Car
    {
        public Car(string model,int speed) 
        {
            Model = model;
            Speed = speed;
           
        }

        public string Model { get; set; }
        public Driver Driver { get; set; }
        public int Speed { get; set; }

        public int CalculateSpeed(Driver driver)
        {

            int sum = 0;
            sum = driver.Level * Speed;
            Console.WriteLine($"The power number for {driver.Name} is: {sum}");
            return sum;
        }

        

    }
}
