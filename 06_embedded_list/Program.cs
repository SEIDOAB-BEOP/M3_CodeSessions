using Helpers;

namespace _06_embedded_list;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("06_embedded_list");

        var n = new csNecklace(30, "African with Pearls as a class");
        Console.WriteLine(n);

        var n1 = new csNecklace1(15, "European with Pearls as a record");
        Console.WriteLine(n1);
    }
}

