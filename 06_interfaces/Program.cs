// See https://aka.ms/new-console-template for more information
using Models;
using Seido.Utilities.SeedGenerator;
var _seeder = new csSeedGenerator();

Console.WriteLine("Hello, World!");
var cars = new List<ICar>();
for (int i = 0; i < 10; i++)
{
    cars.Add(null);
    //cars.Add(new csCar(_seeder));
}


presentGarage(cars);

System.Console.WriteLine("\nOldest car");
var oldie = OldestCar(cars);
System.Console.WriteLine($"Car with reg ny {oldie.RegNr}, owned by {oldie.Owner.FirstName} {oldie.Owner.LastName} is from {oldie.Year}");




void presentGarage (List<ICar> cars)
{
    foreach (var item in cars)
    {
        System.Console.WriteLine($"Car with reg ny {item.RegNr}, owned by {item.Owner.FirstName} {item.Owner.LastName} is from {item.Year}");
    }

}

ICar OldestCar (List<ICar> cars)
{
    int min = int.MaxValue;
    ICar oldestCar = null;
    foreach (var item in cars)
    {
        if (item.Year < min)
        {
            min = item.Year;
            oldestCar = item;
        }
    }
    return oldestCar;
}