using System.ComponentModel.Design;
using Task_2.Classes1;


bool continueDriving;
Driver driver1 = new Driver("Simon", 10);
Driver driver2 = new Driver("Mile", 9);
Driver driver3 = new Driver("Toso", 8);
Driver driver4 = new Driver("Cacko", 7);

Car car1 = new Car("Hyundai", 100);
Car car2 = new Car("Mazda", 120);
Car car3 = new Car("Ferrari", 200);
Car car4 = new Car("Porsche", 160);
Car[] cars = new Car[] { car1, car2, car3, car4 };

Driver[] drivers = new Driver[] { driver1, driver2, driver3, driver4 };

do
{
    Car selectedCar1 = null;
    Car selectedCar2 = null;
    Driver selectedDriver1 = null;
    Driver selectedDriver2 = null;

    Console.WriteLine("Enter car number 1!!! You can choose between: ");
    Console.WriteLine();
    foreach (Car car in cars)
    {
        Console.WriteLine(car.Model);
    }
    Console.WriteLine();
    string carNumber1 = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Enter driver number 1!!! You can choose these drivers: ");
    Console.WriteLine();
    foreach (Driver driver in drivers)
    {
        Console.WriteLine(driver.Name);
    }
    Console.WriteLine();
    string driverNumber1 = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Enter car number 2!!! You can choose between:");
    Console.WriteLine();
    foreach (Car car in cars)
    {
        if (car.Model.ToLower() != carNumber1.ToLower())
            Console.WriteLine(car.Model);
    }
    Console.WriteLine();
    string carNumber2 = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Enter driver number 2!!! You can choose these drivers: ");
    Console.WriteLine();
    foreach (Driver driver in drivers)
    {
        if (driver.Name.ToLower() != driverNumber1.ToLower())
        {
            Console.WriteLine(driver.Name);
        }
    }
    Console.WriteLine();
    string driverNumber2 = Console.ReadLine();
    Console.WriteLine();




    foreach (Car car in cars)
    {
        if (car.Model.ToLower() == carNumber1.ToLower())
        {
            selectedCar1 = car;
        }
        if (car.Model.ToLower() == carNumber2.ToLower())
        {
            selectedCar2 = car;
        }
    }
    foreach (Driver driver in drivers)
    {
        if (driver.Name.ToLower() == driverNumber1.ToLower())
        {
            selectedDriver1 = driver;
        }
        if (driver.Name.ToLower() == driverNumber2.ToLower())
        {
            selectedDriver2 = driver;
        }
    }
    if (selectedCar1 != null && selectedCar2 != null && selectedDriver1 != null && selectedDriver2 != null && driverNumber1.ToLower() != driverNumber2.ToLower() && carNumber1.ToLower() != carNumber2.ToLower())
    {
        RaceCars(selectedCar1, selectedDriver1, selectedCar2, selectedDriver2);

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Wrong input!!!");
        Console.ResetColor();
        Console.WriteLine();
    }
    Console.WriteLine("Continue Driving? Press Y/y for yes or N/n !");
    Console.WriteLine();
    continueDriving = Console.ReadLine().ToLower() == "y";
    Console.WriteLine();
}
while (continueDriving);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Done racing for today!");
Console.ResetColor();


void RaceCars(Car car1, Driver driver1, Car car2, Driver driver2)
{   

    int result1 = car1.CalculateSpeed(driver1);
    Console.WriteLine();
    int result2 = car2.CalculateSpeed(driver2);
    Console.WriteLine();


    if (result1 > result2)
        {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"The car model that won the race was: {car1.Model} driven by the driver {driver1.Name} going {car1.Speed} km/h");
        Console.ResetColor();
        Console.WriteLine();
    }
        if (result1 < result2)
        {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"The car model that won the race was: {car2.Model} driven by the driver {driver2.Name} going {car2.Speed} km/h");
        Console.ResetColor();
        Console.WriteLine();
    }

}









