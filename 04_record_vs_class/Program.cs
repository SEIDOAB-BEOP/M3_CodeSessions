using System.Diagnostics.Contracts;
using Seido.Utilities.SeedGenerator;

namespace _04_record_vs_class;

public enum enPearlColor { Black, White, Pink }
public enum enPearlShape { Round, DropShaped }
public enum enPearlType { FreshWater, SaltWater }

//Immutable Pearl as class
public class csPearl
{
    public int Size { get; init; }
    public enPearlColor Color { get; init; }
    public enPearlShape Shape { get; init; }
    public enPearlType Type { get; init; }

    public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

    public csPearl SetColor (enPearlColor color) => new csPearl(this) {Color = color};
    public csPearl SetShape (enPearlShape shape) => new csPearl(this) {Shape = shape};
    public csPearl SetType (enPearlType type) => new csPearl(this) {Type = type};

    public csPearl() { }
    public csPearl(csSeedGenerator _seeder)
    {
        Size = _seeder.Next(5,25);
        Color = _seeder.FromEnum<enPearlColor>();
        Shape = _seeder.FromEnum<enPearlShape>();
        Type = _seeder.FromEnum<enPearlType>();
    }
    public csPearl(int _size, enPearlColor _color, enPearlShape _shape, enPearlType _type)
    {
        Size = _size;
        Color = _color;
        Shape = _shape;
        Type = _type;
    }
    public csPearl(csPearl org)
    {
        Size = org.Size;
        Color = org.Color;
        Shape = org.Shape;
        Type = org.Type;
    }
}

//immutable pearl as record class
public record class rePearl (int Size, enPearlColor Color, enPearlShape Shape, enPearlType Type)
{
    //Your own constructor, must call this(record properties...)
    public rePearl(csSeedGenerator _seeder) : this (
   
        _seeder.Next(5, 25),
        _seeder.FromEnum<enPearlColor>(),
        _seeder.FromEnum<enPearlShape>(),
        _seeder.FromEnum<enPearlType>())
    { }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("04_record_vs_class");

        var rnd = new csSeedGenerator();
        var p = new csPearl(25,enPearlColor.White, enPearlShape.DropShaped, enPearlType.FreshWater);
        Console.WriteLine(p);

        var p_cs = new csPearl(p) { Size = 5 };
        Console.WriteLine(p_cs);

        var p_cc = p.SetColor(enPearlColor.Pink);
        Console.WriteLine(p_cc);

        var p_rnd = new csPearl(rnd);
        System.Console.WriteLine(p_rnd);


        Console.WriteLine("\n\n");
        var pr = new rePearl(25,enPearlColor.White, enPearlShape.DropShaped, enPearlType.FreshWater);
        Console.WriteLine(pr);

        var pr_cs = pr with { Size = 5 };
        Console.WriteLine(pr_cs);

        var pr_cc = pr with { Color = enPearlColor.Pink };
        Console.WriteLine(pr_cs);

        var pr_rnd = new rePearl(rnd);
        Console.WriteLine(pr_rnd);
    }
}

