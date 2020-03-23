using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        { }

        public override string Description => beverage.Description + ", Mocha";

        public override decimal Cost => beverage.Cost + 0.20M;
    }
}
