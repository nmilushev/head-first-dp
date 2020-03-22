using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string Description { get; }
    }
}
