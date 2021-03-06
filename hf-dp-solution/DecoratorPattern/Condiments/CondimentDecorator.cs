﻿using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal Cost => beverage.Cost;

        public override string Description => beverage.Description;
    }
}
