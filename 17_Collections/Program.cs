// See https://aka.ms/new-console-template for more information
using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello, Collections2!");
var rnd = new csSeedGenerator();

//Instantiate and initialize a list
var pearlList1 = new List<csPearl>();
for (int i = 0; i < 50; i++)
{
    pearlList1.Add(new csPearl(rnd));
}

//Create deep copies
var pearlList2 = pearlList1.Select(p => new csPearl(p)).ToList();

//Sort the list
System.Console.WriteLine("\nSorted List");
pearlList1.Sort();
System.Console.WriteLine($"{nameof(pearlList1)} contains {pearlList1.Count} pearls");
pearlList1.ForEach(pearl => System.Console.WriteLine(pearl));

//Shuffle the list
System.Console.WriteLine("\nShuffled List");
for (int i = 0; i < 1000; i++)
{
    var idx1 = rnd.Next(0, pearlList1.Count);
    var idx2 = rnd.Next(0, pearlList1.Count);
    
    ///swap using tupples
    (pearlList1[idx1], pearlList1[idx2]) = (pearlList1[idx2], pearlList1[idx1]);
}
System.Console.WriteLine($"{nameof(pearlList1)} contains {pearlList1.Count} pearls");
pearlList1.ForEach(pearl => System.Console.WriteLine(pearl));

//Get unique pearls
System.Console.WriteLine("\nUnique items List");
//var pearlsUnique = new HashSet<csPearl>(pearlList1);
var pearlsUnique = new SortedSet<csPearl>(pearlList1);
System.Console.WriteLine($"{nameof(pearlsUnique)} contains {pearlsUnique.Count} pearls");
pearlsUnique.ToList().ForEach(pearl => System.Console.WriteLine(pearl));

//Does the list contain duplicates?
System.Console.WriteLine($"\n{nameof(pearlList1)} contains duplicates: {pearlList1.Count != pearlsUnique.Count}");

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


//List only duplicates
System.Console.WriteLine("\nDuplicates");
var intsDuplicates = new List<csPearl>();
nrPearls.ToList().ForEach(item => 
{
    if (item.Value >= 2)
    {
        intsDuplicates.Add(item.Key);
    }
});

intsDuplicates.ForEach(i => System.Console.WriteLine(i));
System.Console.WriteLine($"{nameof(intsDuplicates)} contains {intsDuplicates.Count} pearls");


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