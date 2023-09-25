namespace _01_class_basics;

class Program
{
    public class Stock
    {
        public decimal Price { get; set; } = 0;
        public int Amount { get; set; } = 0;

        public string Name { get; } = null;

        public decimal TotValue()
        {
            var _amount = Price * Amount;
            return _amount;
        }
        public string WhoAmI()
        {
            var _s = $"My {Name} portfolio is worth {TotValue():N2} Sek";
            return _s;
        }

        public Stock()
        {
            Name = "Volvo";
            Price = 35.30M;
            Amount = 1000;
        }
        public Stock(string _name, decimal _price, int _amount)
        {
            Name = _name;
            Price = _price;
            Amount = _amount;
        }
    }


    static void Main(string[] args)
    {
        var stock1 = new Stock();
        Console.WriteLine(stock1.WhoAmI());

        var stock2 = new Stock("SAS", 2.35M, 100);
        Console.WriteLine(stock2.WhoAmI());
    }
}

