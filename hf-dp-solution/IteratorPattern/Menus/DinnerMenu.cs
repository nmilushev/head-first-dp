using IteratorPattern.Iterators;
using System;

namespace IteratorPattern.Menus
{
    public class DinnerMenu
    {
        private const int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private MenuItem[] menuItems;

        public DinnerMenu()
        {
            this.menuItems = new MenuItem[MAX_ITEMS];

            this.AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);
            this.AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99M);
            this.AddItem("Soup of the day", "Soup of the day, with a side of ptato salad", false, 3.29M);
            this.AddItem("Hotdog", "A hot dog with saurkraut, relish, onions, topped with cheese", false, 3.05M);
        }

        // The old way accessing collection
        //public MenuItem[] GetMenuItems()
        //{
        //	return this.menuItems;
        //}

        // The better way
        public IIterator<MenuItem> CreateIterator()
        {
           //  return this.menuItems.GetEnumerator(); // The C# way
            return new DinnerMenuIterator(this.menuItems);
        }

        private void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);

            if (this.numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Can't add item to menu, menu is full!");
            }
            else
            {
                this.menuItems[numberOfItems] = menuItem;
                this.numberOfItems++;
            }
        }

        // other methods dependent on array type MenuItem[]
    }
}
