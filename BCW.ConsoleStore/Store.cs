using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleStore
{
    class Store
    {
        public List<Item> items = new List<Item>();
        public string Name { get; private set; }
        public Store(string name)
        {
            Name = name;
        }
        // This method will allow you to add an item to the List of Items
        public void AddItemToStore(Item item)
        {
            items.Add(item);
        }

        // This method should remove an item from the list of Items
        public void RemoveItemFromStore(Item item)
        {
            items.Remove(item);
        }
    }
}
