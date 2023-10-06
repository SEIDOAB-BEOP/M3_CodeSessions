using Helpers;
namespace _08_inheritance;

public class csChef
{
    public string Name { get; set; } = "Boring";
    public int Age { get; set; } = 0;

    public string Hello => $"Hello";
    public string FavoriteDish { get; set; } =  "nothing";

    public override string ToString() => $"{Hello}, I am {Name}. I like {FavoriteDish}";

}

public class csFrenchChef : csChef
{
    public List<csWine> WineList { get; set; } = new List<csWine>();

    public List<csWine> MyFavoriteWinesEver()
    {
        var rnd = new csSeedGenerator();
        var _winefav = new List<csWine>();
        for (int i = 0; i < 3; i++)
        {
            _winefav.Add(new csWine(rnd));
        }
        return _winefav;
    }

    public override string ToString()
    {
        string sRet = $"\n{base.ToString()}:";
        foreach (var item in WineList)
        {
            sRet += $"\n{item}";
        }
        return sRet;
    }

    public csFrenchChef()
    {
        var rnd = new csSeedGenerator();
        for (int i = 0; i < 10; i++)
        {
            WineList.Add(new csWine(rnd));
        }
    }
}

public class csGermanChef : csChef
{
    public string PetName { get; set; } = "Max";
    public override string ToString() => $"{base.ToString()}. \nI have a pet called {PetName}";
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Chefs!");

        Console.WriteLine("csChef");
        var chef1 = new csChef();
        Console.WriteLine(chef1);

        Console.WriteLine();
        Console.WriteLine("csFrenchChef");
        var fc = new csFrenchChef() { FavoriteDish = "Escargot" };
        fc.Name = "Jean-Pierre";
        Console.WriteLine(fc);

        Console.WriteLine("Favorite wine");
        var w1 = fc.MyFavoriteWinesEver();
        Console.WriteLine(w1[0]);

        Console.WriteLine();
        Console.WriteLine("csGermanChef");
        var gc = new csGermanChef() { FavoriteDish = "Wurst" }; ;
        gc.Name = "Heinz";
        Console.WriteLine(gc);
    }
}

