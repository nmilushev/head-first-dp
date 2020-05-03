using IteratorPattern.Iterators;
using System.Collections.Generic;

namespace IteratorPattern.Menus
{
	public class PancakeHouseMenu
    {
		private List<MenuItem> menuItems;

		public PancakeHouseMenu()
		{
			this.menuItems = new List<MenuItem>();

			this.AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99M);
			this.AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausage", false, 2.99M);
			this.AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49M);
			this.AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59M);
		}

		// The old way accessing collection
		//public List<MenuItem> GetMenuItems()
		//{
		//	return this.menuItems;
		//}

		public IIterator<MenuItem> CreateIterator()
		{
			return new PancakeHouseMenuIterator(this.menuItems);
		}

		private void AddItem(string name, string description, bool vegetarian, decimal price)
		{
			this.menuItems.Add(new MenuItem(name, description, vegetarian, price));
		}

		// other methods dependent on generic List<MenuItem>
    }
}
