using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso);

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);

            Console.WriteLine(houseBlend);
        }
    }
}
