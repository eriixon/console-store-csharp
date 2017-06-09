using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleStore.Front
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Bills' Gun");
            User user = new User();            

            bool running = true;
            while (running)
            {
                Console.ReadLine();
                running = false;
            }


            //Item pick = new Item("Old Rusty", "A well worn pick it doesn't look like this would last long", 20);
            //Item shield = new Item("Knight's Shield", "A nice looking shield with an unknown emblem", 200);

            //willysEmporium.AddItemToStore(pick);
            //willysEmporium.AddItemToStore(shield);


            //    willysEmporium.ViewItems();
            //    var item = willysEmporium.GetItemByName("Old Rusty");
            //    willysEmporium.AddItemToCart(item);
            //    willysEmporium.ViewCart();
            //    willysEmporium.CalculateCartTotal();
        }
    }
}
