namespace DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        public string Description;

        public abstract double Cost { get; }

        public override string ToString()
        {
            return $"{this.Description} ${this.Cost}";
        }
    }
}
