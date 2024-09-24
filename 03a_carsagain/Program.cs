using Seido.Utilities.SeedGenerator;
using Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

        var rnd = new csSeedGenerator();
        var c1 = new csCar(rnd) {Color = enCarColor.Green, Brand = enCarBrand.Ford};
        System.Console.WriteLine(c1);

        var c2 = new csCar() {Color = enCarColor.Burgundy, Brand = enCarBrand.Ford, Model = enCarModel.Mustang_GT};
        System.Console.WriteLine(c2);

        var c3 = new csCar(enCarColor.Brown, enCarBrand.Jaguar, enCarModel.XF);
        System.Console.WriteLine(c3);

        var c4 = new csCar(c1);
        System.Console.WriteLine(c4 == c1);

        var c5 = c1;
        System.Console.WriteLine(c5 == c1);

        System.Console.WriteLine("Car Pool");
        var cp1 = new csCarPool(rnd, 25);
        System.Console.WriteLine(cp1);

        System.Console.WriteLine("AnotherCar Pool");
        var cars = new List<csCar>();
        cars.Add(c2);
        cars.Add(c3);
        cars.Add(c4);
        cars.Add(c5);
        var cp2 = new csCarPool(cars);
        System.Console.WriteLine(cp2);




        

    
