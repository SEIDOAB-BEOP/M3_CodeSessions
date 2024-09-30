using System.Security.Cryptography;
using Seido.Utilities.SeedGenerator;

namespace Models;

public class csPerson : IPerson
{
    public string FirstName { get ; set; }
    public string LastName { get ; set; }

    public csPerson(csSeedGenerator _seeder)
    {
        FirstName = _seeder.FirstName;
        LastName = _seeder.LastName;
    }
}

public class csCar : ICar
{
    public string RegNr { get; set;}
    public IPerson Owner {get; set;}
    public int Year { get; set;}

    public csCar(csSeedGenerator _seeder)
    {
        RegNr = $"{_seeder.FromString("ABC, FGE, KLM, PTA, RPW, KJH")} {_seeder.Next(100, 1000)}";
        Year = _seeder.Next(1975, 2025);

        Owner = new csPerson(_seeder);
    }
}
