﻿using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using Seido.Utilities.SeedGenerator;

namespace Models;

public enum enPearlColor { Black, White, Pink }
public enum enPearlShape { Round, DropShaped }
public enum enPearlType { FreshWater, SaltWater }

#region Pearl as a class
public class csPearl : IEquatable<csPearl>, IComparable<csPearl>
{
    public int Size { get; init; }
    public enPearlColor Color { get; init; }
    public enPearlShape Shape { get; init; }
    public enPearlType Type { get; init; }

    public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

    #region Implementation of IEquatable<T> interface
    public bool Equals(csPearl other) => (this.Size, this.Color, this.Shape, this.Type) ==
        (other.Size, other.Color, other.Shape, other.Type);

    //Needed to implement as part of IEquatable
    public override bool Equals(object obj) => Equals(obj as csPearl);
    public override int GetHashCode() => (this.Size, this.Color, this.Shape, this.Type).GetHashCode();
    #endregion


    #region Implementation IComparable<T> interface
    public int CompareTo(csPearl other)
    {
        if (this.Size != other.Size)
            return this.Size.CompareTo(other.Size);

        if (this.Color != other.Color)
            return this.Color.CompareTo(other.Color);

        if (this.Shape != other.Shape)
            return this.Shape.CompareTo(other.Shape);

        return this.Type.CompareTo(other.Type);
    }
    #endregion

    public csPearl() { }
    public csPearl(csSeedGenerator _seeder)
    {
        Size = _seeder.Next(5, 25);
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
#endregion


