using System;

namespace IteratorPattern.Iterators
{
    public class DinnerMenuIterator : IIterator<MenuItem>
    {
        private int position = 0;
        private MenuItem[] items;

        public DinnerMenuIterator(MenuItem[] items)
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
            return !(position >= items.Length || items[position] == null);
        }
    }
}
