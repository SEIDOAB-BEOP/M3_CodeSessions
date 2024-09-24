using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Seido.Utilities.SeedGenerator;
namespace Models;

public class csCarPool
{
    public List<csCar> Cars { get; set; } = new List<csCar>();

    public override string ToString(){
        string sRet = "";
        foreach (var item in Cars)
        {
            sRet += $"{item}\n";
        }
        return sRet;
    }

    public csCarPool() {}
    public csCarPool(List<csCar> cars)
    {
        this.Cars = cars;
    }
    public csCarPool(csSeedGenerator _seeder, int nrCars)
    {
        for (int i = 0; i < nrCars; i++)
        {   
            var c = new csCar(_seeder);
            this.Cars.Add(c);
        }
    }
}