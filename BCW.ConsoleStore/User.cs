using System;

namespace BCW.ConsoleStore.Front
{
    public class User
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
            Console.WriteLine($"What do you like to buy. You have {Budget:c}\r\n");
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
                    Console.WriteLine("\n\r***Sorry, you don't have enought money***\n\r");
                    Console.ResetColor();
                }
            }
        }

        public void ReturnItem(Store store)
        {
            Console.WriteLine($"What do you like to return? You have {Budget}");
            var itemToReturn = store.GetItemByNameCart(Console.ReadLine().ToString().ToUpper());
            if (itemToReturn == null) Console.WriteLine("\r\nSorry, you don't have it\r\n");
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
