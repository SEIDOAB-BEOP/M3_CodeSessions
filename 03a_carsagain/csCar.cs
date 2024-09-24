using System.Globalization;
using Seido.Utilities.SeedGenerator;

namespace Models;

public enum enCarColor { Brown, Red, Green, Burgundy}
public enum enCarBrand { Boxcar, Ford, Jaguar, Honda}
public enum enCarModel { Boxmodel, Mustang_GT, XF, Civic}

public class csCar
{
    public enCarColor Color {get; init;}
    public enCarBrand Brand {get; set;}
    public enCarModel Model {get; set;}
    
    public override string ToString() => $"I am a {Color} {Brand} {Model}";

    #region operator overload
    public static bool operator == (csCar a, csCar b) => (a.Color, a.Brand, a.Model) == (b.Color, b.Brand, b.Model);
    public static bool operator != (csCar a, csCar b) => (a.Color, a.Brand, a.Model) != (b.Color, b.Brand, b.Model);
    #endregion


    public csCar(csSeedGenerator _seeder)
    {
        Color = _seeder.FromEnum<enCarColor>();
        Brand = _seeder.FromEnum<enCarBrand>();
        Model = _seeder.FromEnum<enCarModel>();           
    }
    public csCar(){}

    public csCar (enCarColor color, enCarBrand brand, enCarModel model)
    {
        this.Color = color;
        this.Brand = brand;
        this.Model = model;
    }

    public csCar (csCar org)
    {
        this.Color = org.Color;
        this.Brand = org.Brand;
        this.Model = org.Model;
    }
}