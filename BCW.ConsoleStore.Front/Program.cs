using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleStore.Front
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();
            Store store = new Store("Bills' Gun",user.Name);
            AddStoreItems(store);

            bool running = true;
            while (running)
            {
                store.ViewItems();
                store.ViewCart();
                store.CalculateCartTotal();
                StoreMenu();
                string choice = Console.ReadLine().ToString().ToUpper();
                switch (choice)
                {
                    case "BUY":
                        user.BuyItem(store);
                        break;
                    case "RETURN":
                        user.ReturnItem(store);
                        break;
                    case "QUIT":
                        Console.WriteLine("Thank you for visiting {0} store", store.Name);
                        Console.ReadLine();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, we don't have it");
                        break;
                }
            }
        }
        public static void StoreMenu()
        {
            Console.WriteLine("What do you like to do?");
            Console.WriteLine("If you want to buy something - input 'buy'");
            Console.WriteLine("If you want to return something - input 'retun'");
            Console.WriteLine("If you want to leave - input 'quit'");
            Console.WriteLine();
        }
        public static void AddStoreItems(Store store)
        {
            store.AddItemToStore(new Item("Gun", "10 mm semiato Zombi Punisher", 50));
            store.AddItemToStore(new Item("Shotgun", "12 Gauge Zombi Destroyer", 150));
            store.AddItemToStore(new Item("Rifle", "7.62x39mm Caliber Freedom Maker", 100));
            store.AddItemToStore(new Item("Axe", "Old Friend", 25));
        }

    }
}
