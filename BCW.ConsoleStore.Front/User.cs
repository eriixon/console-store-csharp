using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleStore.Front
{
    class User
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public User()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine().ToString();
            Console.WriteLine("What is your budget?");
            bool running = true;
            while (running)
            {
                try
                {
                    Budget = Decimal.Parse(Console.ReadLine());
                    running = false;
                }
                catch 
                {
                    Console.WriteLine("It should be a number");
                }
            }
        }
        public void BuyItem(Store store)
        {
            Console.WriteLine("What do you like to buy. You have {0:c}", Budget);
            Console.WriteLine();
            var itemToBuy = store.GetItemByNameStore(Console.ReadLine().ToString().ToUpper());
            if (itemToBuy == null) Console.WriteLine("Sorry, we don't have it");
            else
            {
                if (itemToBuy.Price <= Budget)
                {
                    store.AddItemToCart(itemToBuy);
                    store.RemoveItemFromStore(itemToBuy);
                    Budget -= itemToBuy.Price;
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n***Sorry, you don't have enought money***");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
        }

        public void ReturnItem(Store store)
        {
            Console.WriteLine("What do you like to return? You have {0}", Budget);
            var itemToReturn = store.GetItemByNameCart(Console.ReadLine().ToString().ToUpper());
            if (itemToReturn == null) Console.WriteLine("Sorry, you don't have it");
            else
            {
                store.AddItemToStore(itemToReturn);
                store.RemoveItemFromCart(itemToReturn);
                Budget += itemToReturn.Price;
                Console.WriteLine();
            }
        }
    }
}
