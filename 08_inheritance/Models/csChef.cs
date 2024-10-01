namespace Models;
public class csChef
{
    public string Name { get; set; } = "Boring";
    public int Age { get; set; } = 0;

    public virtual string Hello => $"Eehh";
    public string FavoriteDish { get; set; } =  "nothing";

    public override string ToString() => $"{Hello}, I am {Name}. {Age} years old. I like {FavoriteDish}";


}

public class csSwedishChef : csChef
{
    public override string Hello => $"Halloj";
    //public new string Hello => $"Halloj";
    public int NrOfChildren { get; set; }

    public csSwedishChef()
    {
        Name = "Harry";
        Age = 60;
        FavoriteDish = "Meatballs";
        NrOfChildren = 5;
    }
}

public class csItalianChef : csChef
{
    public override string Hello => $"Ciao";
    //public new string Hello => $"Ciao";
    public string FavoriteWine { get; set;}

}
