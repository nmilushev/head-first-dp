using FactoryMethodPattern.Pizzas;
using System;

namespace FactoryMethodPattern.Stores
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                //case "pepperoni":
                //    return new ChicagoStylePepperoniPizza();
                //case "clam":
                //    return new ChicagoStyleClamPizza();
                //case "veggie":
                //    return new ChicagoStyleVeggiePizza();
                default:
                    throw new NotSupportedException("We cannot cook this type of Pizza!");
            }
        }
    }
}
