using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        { }

        public override string Description => beverage.Description + ", Whip";

        public override decimal Cost => beverage.Cost + 0.30M;
    }
}
