using System;
using System.Collections.Generic;
using System.Linq;

namespace BCW.ConsoleStore
{
    public class Store
    {
        public List<IItem> Items = new List<IItem>();
        public string Name { get; private set; }
        public Cart cart = new Cart();

        public Store(string name, string userName)
        {
            Name = name;
            Console.WriteLine("********************************");
            Console.WriteLine($"Welcome {Name} to {userName} Store");
            Console.WriteLine("********************************");
        }

        public void AddItemToStore(IItem item)
        {
            Items.Add(item);
        }

        public void RemoveItemFromStore(IItem item)
        {
            Items.Remove(item);
        }
              
        public IItem GetItemByNameStore(string name)
        {
            return Items.FirstOrDefault(item => item.Name.ToLower() == name.ToLower());
        }

        public void ViewStoreItems()
        {
            DisplayItems.Display(Items,"Store");
        }
    }
}
