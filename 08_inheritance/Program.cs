using Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Inheritance!");
System.Console.WriteLine("\nChef");
var chef = new csChef();
System.Console.WriteLine(chef);

System.Console.WriteLine("\nSwedish Chef");
csChef chef1 = new csSwedishChef();
csSwedishChef s_chef = (csSwedishChef)chef1;

System.Console.WriteLine($"csChef Hello: {chef1.Hello}");
System.Console.WriteLine($"csSwedishChef Hello: {s_chef.Hello}");
System.Console.WriteLine($"csSwedishChef NrOfChildren: {s_chef.NrOfChildren}");

System.Console.WriteLine("\nItalian Chef");
csChef chef2 = new csItalianChef(){ Name = "Mauro", Age = 35, 
                                  FavoriteDish="Spagetti", FavoriteWine = "Chataux de paraply"};
csItalianChef i_chef = (csItalianChef)chef2;

System.Console.WriteLine($"csChef Hello: {chef2.Hello}");
System.Console.WriteLine($"csItalianChef Hello: {i_chef.Hello}");
System.Console.WriteLine($"csItalianChef FavoriteWine: {i_chef.FavoriteWine}");

System.Console.WriteLine("\nList of Chefs");
List<csChef> chefs = new List<csChef>();
chefs.Add(s_chef);
chefs.Add(i_chef);

foreach (var item in chefs)
{
    System.Console.WriteLine(item);
}





