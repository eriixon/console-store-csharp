using System;

namespace BCW.ConsoleStore.Front
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player();
            Store store = new Store("Bills' Gun",player.Name);
            AddStoreItems(store);
            store.ViewStoreItems();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\r\nSo.. If you want to buy something - input 'buy', to return - input 'retun', or you want to leave the store - input 'quit'\r\n");
                string choice = Console.ReadLine().ToString().ToUpper();
                switch (choice)
                {
                    case "BUY":
                        store.ViewStoreItems();
                        player.BuyItem(store);
                        store.cart.ViewCart();
                        store.cart.CalculateCartTotal();
                        break;
                    case "RETURN":
                        store.cart.ViewCart();
                        player.ReturnItem(store);
                        break;
                    case "QUIT":
                        Console.WriteLine("Thank you for visiting our store");
                        player.PurchasePayment(store.cart);
                        Console.ReadLine();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, we don't have it");
                        break;
                }
            }
        }
        public static void AddStoreItems(Store store)
        {
            store.AddItemToStore(new Weapon("Axe", "Old Friend", 25, 5));
            store.AddItemToStore(new Weapon("Pistol", "10 mm semiato Zombi Punisher", 50, 10));
            store.AddItemToStore(new Weapon("Rifle", "7.62x39mm Caliber Freedom Maker", 100, 15));
            store.AddItemToStore(new Weapon("Shotgun", "12 Gauge Zombi Destroyer", 150, 20));
            store.AddItemToStore(new Protection("Helmet", "Old steel bowl", 25, 5));
            store.AddItemToStore(new Protection("Plate", "Heavy metall plate", 50, 10));
            store.AddItemToStore(new Protection("Vest", "Light kevlar vest", 100, 15));
        }
    }
}
