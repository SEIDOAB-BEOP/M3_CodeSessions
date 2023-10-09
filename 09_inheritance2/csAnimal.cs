using System;
namespace _09_inheritance2
{
	public class csAnimal
	{
		public string Noise() => "Clonk";
	}
	public class csDog : csAnimal
	{
        //public string Noise() => "Voff";
    }
    public class csCat : csAnimal
    {
        //public string Noise() => "Meow";
    }
    public class csLabrador : csDog
    {
        //public string Noise() => "Voff Voff Rauw!";
    }
}

