using System;

namespace BCW.ConsoleStore.Front
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();
            Store store = new Store("Bills' Gun",user.Name);
            AddStoreItems(store);
            store.ViewItems();

            bool running = true;
            while (running)
            {
                StoreMenu();
                string choice = Console.ReadLine().ToString().ToUpper();
                switch (choice)
                {
                    case "BUY":
                        store.ViewItems();
                        user.BuyItem(store);
                        store.ViewCart();
                        store.CalculateCartTotal();
                        break;
                    case "RETURN":
                        store.ViewCart();
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
            Console.WriteLine("If you want to buy something - input 'buy', to return - input 'retun', or you want to leave - input 'quit'");
            Console.WriteLine();
        }
        public static void AddStoreItems(Store store)
        {
            store.AddItemToStore(new Item("Pistol", "10 mm semiato Zombi Punisher", 50));
            store.AddItemToStore(new Item("Shotgun", "12 Gauge Zombi Destroyer", 150));
            store.AddItemToStore(new Item("Rifle", "7.62x39mm Caliber Freedom Maker", 100));
            store.AddItemToStore(new Item("Axe", "Old Friend", 25));
        }
    }
}
