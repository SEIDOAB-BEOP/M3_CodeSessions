using Helpers;

namespace _06_embedded_list;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Necklace!");

        var n = new csNecklace(30, "African");
        Console.WriteLine(n);

        n = new csNecklace(15, "European");
        Console.WriteLine(n);
    }
}

