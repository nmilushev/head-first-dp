namespace FactoryMethodPattern.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            base.Name = "NY Style Sauce and Cheese Pizza";
            base.Dough = "Thin Crust";
            base.Sauce = "Marinara";

            base.Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
