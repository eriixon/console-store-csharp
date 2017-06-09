using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleStore.Front
{
    class User
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public User()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine().ToString();
            Console.WriteLine("What is your budget?");
            Budget = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Hello {0} with {1:c}", Name, Budget);
        }
    }
}
