namespace DecoratorPattern.Beverages
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            base.Description = "Espresso";
        }

        public override double Cost => 1.99;
    }
}
