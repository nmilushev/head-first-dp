using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    class Mocha : CondimentDecorator
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Mocha";

        public override double Cost => beverage.Cost + 0.20;
    }
}
