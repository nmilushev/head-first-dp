using System;

namespace FactoryMethodPattern.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            base.Name = "Chicago Syle Deep Dish Cheese Pizza";
            base.Dough = "Extra Thick Crust";
            base.Sauce = "Plum Tomato";

            base.Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
