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
        public enCarColor Color;

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
        #endregion
    }
}

