using System;
using System.Collections.Generic;
using System.Linq;

namespace BCW.ConsoleStore.Front
{
    public class Player
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        int Health = 100;
        Inventory Inventory = new Inventory();
        Weapon EquipedWeapon = new Weapon();
        Protection EquipedProtection = new Protection();

        public void Attack()
        {
            if (EquipedWeapon != null) EquipedWeapon.Attack();
            else Console.WriteLine("Player Has no weapon... Throws punch instead. Deal: 1 damage.");
        }
        public void OnAttacked()
        {
            var damage = 20;
            if (EquipedProtection != null) damage = EquipedProtection.Block(damage);
            else Console.WriteLine("You don't have any protection... It'd be better to buy one..");
            Health -= damage;
        }
        public void EquipSword()
        {
            List<Weapon> weapons = (List<Weapon>)Inventory.InventoryItems.Where(item => item is Weapon);
            weapons.ForEach(item => { if (EquipedWeapon == null || EquipedWeapon.Damage < item.Damage) { EquipedWeapon = item; } });
        }
        public void EquipShield()
        {
            List<Protection> weapons = (List<Protection>)Inventory.InventoryItems.Where(item => item is Protection);
            weapons.ForEach(item => { if (EquipedProtection == null || EquipedProtection.DamageModifier < item.DamageModifier) { EquipedProtection = item; } });
        }

        public void PurchasePayment(Cart cart)
        {
            Budget -= cart.CalculateCartTotal();
            Console.WriteLine($"Your budget is {Budget}");
            cart.CartItems.ForEach(item => Inventory.AddIntentory(item));
            cart.CartItems = new List<IItem>();
            Inventory.ViewInventory();
        }

        public Player()
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
            Console.WriteLine($"\r\nWhat do you like to buy. You have {Budget:c}");
            var itemToBuy = store.GetItemByNameStore(Console.ReadLine().ToString().ToUpper());
            decimal cartTotal = store.cart.CalculateCartTotal();
            if (itemToBuy == null) Console.WriteLine("Sorry, we don't have it");
            else
            {
                if ((itemToBuy.Price+cartTotal) <= Budget)
                {
                    store.cart.AddItemToCart(itemToBuy);
                    store.RemoveItemFromStore(itemToBuy);
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
            var itemToReturn = store.cart.GetItemByNameCart(Console.ReadLine().ToString().ToUpper());
            if (itemToReturn == null) Console.WriteLine("\r\nSorry, you don't have it\r\n");
            else
            {
                store.AddItemToStore(itemToReturn);
                store.cart.RemoveItemFromCart(itemToReturn);
                Budget += itemToReturn.Price;
                Console.WriteLine();
            }
        }
    }
}
