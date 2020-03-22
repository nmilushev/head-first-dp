using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    class Whip : CondimentDecorator
    {
        private Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Whip";

        public override double Cost => beverage.Cost + 0.30;
    }
}
