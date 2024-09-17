// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int NrArts = 0;
stArt[] _arts = new stArt[10];

_arts[0] = new stArt {Name ="Apple", Price = 12.3M}; NrArts++;
_arts[5] = new stArt {Name ="Banana", Price = 15.3M};NrArts++;
_arts[7] = new stArt {Name ="Beer", Price = 25.3M};NrArts++;


System.Console.WriteLine($"NrArts: {NrArts}");
foreach (var item in _arts)
{
    if (item.Price != null)
    System.Console.WriteLine($"name: {item.Name}, price: {item.Price}");
}

Console.ReadLine();
_arts[5].Name = null;
_arts[5].Price = null;
NrArts--;

System.Console.WriteLine($"NrArts: {NrArts}");
foreach (var item in _arts)
{
    if (item.Price != null)
    System.Console.WriteLine($"name: {item.Name}, price: {item.Price}");
}

Console.ReadLine();
_arts[5].Name = "Book";
_arts[5].Price = 25.78M;
NrArts++;


System.Console.WriteLine($"NrArts: {NrArts}");
foreach (var item in _arts)
{
    if (item.Price != null)
    System.Console.WriteLine($"name: {item.Name}, price: {item.Price}");
}

struct stArt {
    public string Name;
    public decimal? Price;
}