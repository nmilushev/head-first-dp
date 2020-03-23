namespace DecoratorPattern.Beverages
{
    class HouseBlend : Beverage
    {
        public override string Description => "House Blend Coffee";

        public override decimal Cost => 0.89M;
    }
}
