namespace DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        public abstract string Description { get; }

        public abstract decimal Cost { get; }

        public override string ToString()
        {
            return $"{this.Description} ${this.Cost}";
        }
    }
}
