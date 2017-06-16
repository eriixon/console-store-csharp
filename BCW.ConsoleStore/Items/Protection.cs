using System;

namespace BCW.ConsoleStore
{
    public class Protection : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DamageModifier { get; set; }

        public int Block (int baseDamage)
        {
            int blockedDamage = DamageModifier;
            Console.WriteLine($"Use {Name} to block {blockedDamage} damage.");
            return baseDamage - blockedDamage;
        }

        public Protection(string name, string description, decimal price, int damageModifier)
        {
            Name = name;
            Description = description;
            Price = price;
            DamageModifier = damageModifier;
        }
        public Protection()
        {

        }
    }
}
