using FactoryMethodPattern.Pizzas;
using FactoryMethodPattern.Stores;
using System;

namespace FactoryMethodPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");
            Console.WriteLine();
            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}");
        }
    }
}
