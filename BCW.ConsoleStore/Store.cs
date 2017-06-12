using System;
using System.Collections.Generic;
using System.Linq;

namespace BCW.ConsoleStore
{
    public class Store
    {
        public List<Item> Items = new List<Item>();
        public string Name { get; private set; }
        // Store constructor
        public Store(string name, string userName)
        {
            Name = name;
            Console.WriteLine("********************************");
            Console.WriteLine($"Welcome {Name} to {userName} Store");
            Console.WriteLine("********************************");
        }
        // This method will allow you to add an item to the List of Items
        public void AddItemToStore(Item item)
        {
            Items.Add(item);
        }

        // This method should remove an item from the list of Items
        public void RemoveItemFromStore(Item item)
        {
            Items.Remove(item);
        }
        // Alright now lets go ahead and add a cart property to the Store class.
        // The cart is also going to be a list of items that will be managed through the following methods
        public List<Item> cart = new List<Item>();
        // This method will allow you to add an item from the Items list to the Cart
        public void AddItemToCart(Item item)
        {
            cart.Add(item);
        }
        // This method should remove an item from the Cart
        public void RemoveItemFromCart(Item item)
        {
            cart.Remove(item);
        }
        // This method should calculate the total price of the items in the cart
        public void CalculateCartTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total price of the cart is {cart.Sum(item => item.Price)}\r\n");
            Console.ResetColor();
        }
        // Okay now we need an interface that a user can interact with.You will need to write out the following methods still in the Store class so we can actually build an application.
        public void ViewItems()
        {
            // This method should log All of the items in the store to the screen
            Console.WriteLine($"\r\nItems in the {Name} Store");
            DisplayItemList(Items);
        }
        public void ViewCart()
        {
            // This method will log all the items in the cart and show the total price of the items in the cart
            Console.WriteLine("\r\nItems in the Cart");
            DisplayItemList(cart);
        }

        public Item GetItemByName(List<Item> list, string name)
        {
            // This method should search the given list of items for an item by its name
            // If the item is found return the Item. You could handle case sensitivity here
            return list.FirstOrDefault(item => item.Name.ToLower() == name.ToLower());
        }
        public Item GetItemByNameStore(string name)
        {
            return GetItemByName(Items, name);
        }
        public Item GetItemByNameCart(string name)
        {
            return GetItemByName(cart, name);
        }

        private void DisplayItemList (List<Item> list)
        {
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0,-10} {1,-40} {2,-10}", "Name", "Description", "Price");
            Console.ResetColor();
            list.ForEach(item => Console.WriteLine($"{item.Name,-10} {item.Description,-40} {item.Price,-10:c}"));
        }
    }
}
