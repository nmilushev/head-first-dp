namespace DecoratorPattern.Beverages
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            base.Description = "House Blend Coffee";
        }

        public override double Cost => 0.89;
    }
}
