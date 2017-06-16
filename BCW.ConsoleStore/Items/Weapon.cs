using System;

namespace BCW.ConsoleStore
{
    public class Weapon : IItem
    {
        public string Name { get ; set ; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Damage { get; set; }
        public void Attack()
        {
            Console.WriteLine($"Weapon {Name} deal {Damage} damages.");
        }
        public Weapon(string name, string description, decimal price, int damage)
        {
            Name = name;
            Description = description;
            Price = price;
            Damage = damage;
        }
        public Weapon()
        {

        }
    }
}
