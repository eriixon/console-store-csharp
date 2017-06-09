using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleStore
{
    public class Item
    {
        //Each item will need at least the following properties you should be able to guess the datatypes for each
        //    Name
        //    Description
        //    Price
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        //We also need a way to create items so be sure to create a constructor
        public Item(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

    }
}
