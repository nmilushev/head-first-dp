namespace IteratorPattern
{
    public class MenuItem
    {
        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {
            Name = name;
            Description= description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public string Name { get; }

        public string Description { get; }

        public bool Vegetarian { get; }

        public decimal Price { get; }

    }
}
