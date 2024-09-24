using Seido.Utilities.SeedGenerator;

namespace _01_Cars;

class Program
{

    public enum enCarColor
    {
        Brown, Red, Green, Burgundy
    }
    public enum enCarBrand
    {
        Boxcar, Ford, Jaguar, Honda
    }
    public enum enCarModel
    {
        Boxmodel, Mustang_GT, XF, Civic
    }
    class csCar
    {
        public enCarColor Color {get; set;}
        public string RegNr {get; set;}

        public override string ToString() => $"{Color} {RegNr}";
        public csCar()
        {
            var rnd = new csSeedGenerator();
            Color = rnd.FromEnum<enCarColor>();
            RegNr = $"{rnd.FromString("ABC, FGE, KLM, PTA, RPW, KJH")} {rnd.Next(100, 1000)}";
        }
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Class exploration with Cars!");

        #region how To use the seed generator
        var rnd = new csSeedGenerator();

        //A random enCarColor
        Console.WriteLine(rnd.FromEnum<enCarColor>());

        //A random enCarBrand
        Console.WriteLine(rnd.FromEnum<enCarBrand>());

        //A random enCarModel
        Console.WriteLine(rnd.FromEnum<enCarModel>());

        var regNr = $"{rnd.FromString("ABC, FGE, KLM, PTA, RPW, KJH")} {rnd.Next(100, 1000)}";
        Console.WriteLine(regNr);
        #endregion

        var cars = new List<csCar>();
        for (int i = 0; i < 1000; i++)
        {
            var c1 = new csCar() {Color = enCarColor.Burgundy};
            cars.Add(c1);
        }

        foreach (var item in cars)
        {
                System.Console.WriteLine(item);

        }

        var cars2 = cars;
        cars2[0].RegNr = "WHAAT";

        System.Console.WriteLine(cars[0]);
        System.Console.WriteLine(cars2[0]);
    }
}

