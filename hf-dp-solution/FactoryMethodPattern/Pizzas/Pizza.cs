using System;
using System.Collections.Generic;

namespace FactoryMethodPattern.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine($"Tossing {Dough} dough...");
            Console.WriteLine($"Adding {Sauce} sauce");
            Console.WriteLine("Adding toppings: ");

            foreach (var topping in Toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
