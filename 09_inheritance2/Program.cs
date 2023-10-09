namespace _09_inheritance2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Cats and Dogs!");
        Console.WriteLine(new csAnimal().Noise());
        Console.WriteLine(new csDog().Noise());
        Console.WriteLine(new csCat().Noise());
        Console.WriteLine(new csLabrador().Noise());

        csAnimal[] animals = new csAnimal[4];
        animals[0] = new csAnimal();
        animals[1] = new csAnimal();
        animals[2] = new csAnimal();
        animals[3] = new csAnimal();

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Noise());
        }

        Console.ReadKey();
    }
}

