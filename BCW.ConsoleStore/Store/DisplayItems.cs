using System;
using System.Collections.Generic;
using System.Linq;

namespace BCW.ConsoleStore
{
    public static class DisplayItems
    {
        public static void Display(List<IItem> list, string place)
        {
            if (list.Count() < 1) Console.WriteLine($"{place} is empty");
            else
            {
                Console.WriteLine($"\r\nItems in the {place}");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0,-10} {1,-40} {2,-10} {3,-10} {4,-10}", "Name", "Description", "Price", "Damage", "Protection");
                Console.ResetColor();
                foreach (Weapon item in list.Where(item => item is Weapon))
                {
                    Console.WriteLine($"{item.Name,-10} {item.Description,-40} {item.Price,-11:c}{item.Damage,-11}{"-",-11}");
                }
                foreach (Protection item in list.Where(item => item is Protection))
                {
                    Console.WriteLine($"{item.Name,-10} {item.Description,-40} {item.Price,-11:c}{"-",-11}{item.DamageModifier,-11}");
                }
            }
        }
    }
}
