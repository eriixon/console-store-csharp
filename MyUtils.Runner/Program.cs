using BCW.ConsoleStore.MyUtils;
using System;
using System.Diagnostics;

namespace MyUtils.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var helpers = new Helpers();
            var order = new OrderState
            {
                OrderId = 12345,
            };
            order.AddLineItem(97, "Left Shoe", 27.98m);
            order.AddLineItem(98, "Right Shoe", 59.99m);
            order.AddLineItem(1012, "Ice Cream", 1.55m);

            order.ChangeShippingAddress("123 Fake Street", "Meridian", "ID", "83646");

            order.UpdateOrderStatus(OrderStatus.Shipped);

            helpers.SerializeToFile(order, "order.json");

            order = new OrderState();

            Debug.Assert(order.OrderId != 12345);

            order = helpers.DeserializeFromFile<OrderState>("order.json");
            Debug.Assert(order.OrderId == 12345);
            Debug.Assert(order.LineItems.Count == 3);
            Debug.Assert(order.LineItems[2].ProductId == 1012);
            Debug.Assert(order.LineItems[2].Name == "Ice Cream");
            Debug.Assert(order.LineItems[2].Price == 1.55m);
            Debug.Assert(order.ShippingAddress.Street == "123 Fake Street");
            Debug.Assert(order.ShippingAddress.City == "Meridian");
            Debug.Assert(order.ShippingAddress.State == "ID");
            Debug.Assert(order.ShippingAddress.Zip == "83646");
            Debug.Assert(order.Status == OrderStatus.Shipped);

            Console.WriteLine("YAY IT WORKS!");
            Console.ReadLine();
        }
    }
}
