// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Inheritance!");
System.Console.WriteLine("\nChef");
var chef = new csChef();
System.Console.WriteLine(chef);

System.Console.WriteLine("\nSwedish Chef");
csChef chef1 = new csSwedishChef();
csSwedishChef s_chef = (csSwedishChef)chef1;

System.Console.WriteLine(chef1.Hello);
System.Console.WriteLine(s_chef.Hello);

System.Console.WriteLine("\nItalian Chef");
csChef chef2 = new csItalianChef(){ Name = "Mauro", Age = 35, 
                                  FavoriteDish="Spagetti", FavoriteWine = "Chataux de paraply"};
csItalianChef i_chef = (csItalianChef)chef2;

System.Console.WriteLine(chef2.Hello);
System.Console.WriteLine(i_chef.Hello);


System.Console.WriteLine("\nList of Chefs");
List<csChef> chefs = new List<csChef>();
chefs.Add(s_chef);
chefs.Add(i_chef);

foreach (var item in chefs)
{
    System.Console.WriteLine(item.Hello);
}





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
    public override string Hello => $"Hallo";
    public int NrOfChildren { get; set; }

    public csSwedishChef()
    {
        Name = "Martin";
        Age = 60;
        FavoriteDish = "Meatballs";
        NrOfChildren = 5;
    }
}

public class csItalianChef : csChef
{
    public override string Hello => $"Ciao";
    public string FavoriteWine { get; set;}

}
