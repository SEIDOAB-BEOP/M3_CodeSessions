// See https://aka.ms/new-console-template for more information
using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello, Collections!");
var rnd = new csSeedGenerator();

//Make a large list
var pearlList1 = new List<csPearl>();
for (int i = 0; i < 50; i++)
{
    pearlList1.Add(new csPearl(rnd));
}

//Create deep copies
var pearlList2 = pearlList1.Select(p => new csPearl(p)).ToList();
var pearlList3 = pearlList1.Select(p => new csPearl(p)).ToList();

//Sort the list
pearlList1.Sort();
System.Console.WriteLine($"\n{nameof(pearlList1)} contains {pearlList1.Count} pearls");
pearlList1.ForEach(pearl => System.Console.WriteLine(pearl));

//Get unique pearls
var pearlUnique = new HashSet<csPearl>(pearlList1);
System.Console.WriteLine($"\n{nameof(pearlUnique)} contains {pearlUnique.Count} pearls");
pearlUnique.ToList().ForEach(pearl => System.Console.WriteLine(pearl));

//Get the pearls which were in duplicates
pearlUnique.ToList().ForEach(pearl => pearlList1.Remove(pearl));
var pearlDuplicates = new HashSet<csPearl>(pearlList1);
System.Console.WriteLine($"\n{nameof(pearlDuplicates)} contains {pearlDuplicates.Count} pearls");
pearlDuplicates.ToList().ForEach(pearl => System.Console.WriteLine(pearl));

//Use Dictionary to Get Nr of pieces of each pearl
System.Console.WriteLine("\nNr of pieces of each pearl");
var nrPearls = new Dictionary<csPearl, int>();
pearlList2.ForEach (p => {
    if (nrPearls.ContainsKey(p))
    {
         nrPearls[p]++;
    }
    else
    {
        nrPearls.Add(p, 1);
    }
});
nrPearls.ToList().ForEach(item => System.Console.WriteLine($"{item.Value}pcs of {item.Key}"));


//List only pairs and above
System.Console.WriteLine("\nPairs and above");
nrPearls.ToList().ForEach(item => 
{
    if (item.Value >= 2)
        System.Console.WriteLine($"{item.Value}pcs of {item.Key}");
});


//Get the nr of pearls according to Color
System.Console.WriteLine("\nNr pearls according to Color");
var nrPearlsColor = new Dictionary<enPearlColor, int>();
pearlList2.ForEach (p => {
    if (nrPearlsColor.ContainsKey(p.Color))
    {
         nrPearlsColor[p.Color]++;
    }
    else
    {
        nrPearlsColor.Add(p.Color, 1);
    }
});
nrPearlsColor.ToList().ForEach(item => System.Console.WriteLine($"{item.Value}pcs of {item.Key} pearls"));

//Get the nr of pearls according to Color and type
System.Console.WriteLine("\nNr pearls according to Color and type");
var nrPearlsColorType = new Dictionary<(enPearlColor, enPearlType), int>();
pearlList2.ForEach (p => {
    if (nrPearlsColorType.ContainsKey((p.Color, p.Type)))
    {
         nrPearlsColorType[(p.Color, p.Type)]++;
    }
    else
    {
        nrPearlsColorType.Add((p.Color, p.Type), 1);
    }
});
nrPearlsColorType.ToList().ForEach(item => System.Console.WriteLine($"{item.Value}pcs of {item.Key} pearls"));