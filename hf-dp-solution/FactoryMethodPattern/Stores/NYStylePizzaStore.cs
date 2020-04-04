using FactoryMethodPattern.Pizzas;
using System;

namespace FactoryMethodPattern.Stores
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                //case "pepperoni":
                //    return new NYStylePepperoniPizza();
                //case "clam":
                //    return new NYStyleClamPizza();
                //case "veggie":
                //    return new NYStyleVeggiePizza();
                default:
                    throw new NotSupportedException("We cannot cook this type of Pizza!");
            }
        }
    }
}
