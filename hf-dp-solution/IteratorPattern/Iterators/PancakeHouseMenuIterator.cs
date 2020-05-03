using System.Collections.Generic;

namespace IteratorPattern.Iterators
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        private List<MenuItem> items;
        private int position;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        { 
            this.items = items;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = this.items[position];
            position++;

            return menuItem;
        }

        public bool HasNext()
        {
            return !(position >= items.Count);
        }
    }
}
