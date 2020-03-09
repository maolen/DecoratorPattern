using Starbuzz.Condiments;
using System;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage espresso = new Espresso();
            Console.WriteLine($"{espresso.Description} ${espresso.Cost}");
            IBeverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.Description} ${darkRoast.Cost}");

            IBeverage houseBlend = new HouseBlend(); 
            houseBlend = new Soy(houseBlend); 
            houseBlend = new Mocha(houseBlend); 
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"{houseBlend.Description} ${houseBlend.Cost}");
            Console.ReadKey();
        }
    }
}
