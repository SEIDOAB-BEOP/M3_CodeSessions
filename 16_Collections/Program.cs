// See https://aka.ms/new-console-template for more information
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello, Collections1!");
var rnd = new csSeedGenerator();

//Instantiate and initialize a list
var ints1 = new List<int>();
for (int i = 0; i < 50; i++)
{
    ints1.Add(rnd.Next(0,100));
}

//Create deep copies
var ints2 = ints1.Select(i => i).ToList();

//Sort the list
System.Console.WriteLine("\nSorted List");
ints1.Sort();
System.Console.WriteLine($"{nameof(ints1)} contains {ints1.Count} ints");
ints1.ForEach(i => System.Console.WriteLine(i));

//Shuffle the list
System.Console.WriteLine("\nShuffled List");
for (int i = 0; i < 1000; i++)
{
    var idx1 = rnd.Next(0, ints1.Count);
    var idx2 = rnd.Next(0, ints1.Count);
    
    ///swap using tupples
    (ints1[idx1], ints1[idx2]) = (ints1[idx2], ints1[idx1]);
}
System.Console.WriteLine($"{nameof(ints1)} contains {ints1.Count} ints");
ints1.ForEach(i => System.Console.WriteLine(i));


//Get unique ints
System.Console.WriteLine("\nUnique items List");
var intsUnique = new HashSet<int>(ints1);
//var intsUnique = new SortedSet<int>(ints1);
System.Console.WriteLine($"{nameof(intsUnique)} contains {intsUnique.Count} ints");
intsUnique.ToList().ForEach(i => System.Console.WriteLine(i));

//Does the list contain duplicates?
System.Console.WriteLine($"\n{nameof(ints1)} contains duplicates: {ints1.Count != intsUnique.Count}");

//Use Dictionary to Get Nr of pieces of each int
System.Console.WriteLine("\nNr of pieces of each ints");
var nrInts = new Dictionary<int, int>();
ints2.ForEach (p => {
    if (nrInts.ContainsKey(p))
    {
         nrInts[p]++;
    }
    else
    {
        nrInts.Add(p, 1);
    }
});
nrInts.ToList().ForEach(item => System.Console.WriteLine($"{item.Value}pcs of {item.Key}"));


//List only duplicates
System.Console.WriteLine("\nDuplicates");
var intsDuplicates = new List<int>();
nrInts.ToList().ForEach(item => 
{
    if (item.Value >= 2)
    {
        intsDuplicates.Add(item.Key);
    }
});

intsDuplicates.ForEach(i => System.Console.WriteLine(i));
System.Console.WriteLine($"{nameof(intsDuplicates)} contains {intsDuplicates.Count} ints");
