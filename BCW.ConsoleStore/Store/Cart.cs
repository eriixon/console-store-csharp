using System;
using System.Collections.Generic;
using System.Linq;

namespace BCW.ConsoleStore
{
    public class Cart
    {
        public List<IItem> CartItems = new List<IItem>();

        public void AddItemToCart(IItem item)
        {
            CartItems.Add(item);
        }
        public void RemoveItemFromCart(IItem item)
        {
            CartItems.Remove(item);
        }
        public decimal CalculateCartTotal()
        {
            return CartItems.Sum(item => item.Price);
        }
        public void DisplayTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total price of the cart is {CalculateCartTotal()}\r\n");
            Console.ResetColor();
        }
        public IItem GetItemByNameCart(string name)
        {
            return CartItems.FirstOrDefault(item => item.Name.ToLower() == name.ToLower());
        }
        public void ViewCart()
        {
            DisplayItems.Display(CartItems, "Cart");
        }
    }
}
