using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtils.Runner
{
    public enum OrderStatus { Ordered, Shipped, Delivered };

    public interface IOrderState
    {
        int OrderId { get; set; }
        Address ShippingAddress { get; set; }
        List<LineItem> LineItems { get; set; }
        OrderStatus Status { get; set; }

        void AddLineItem(int productId, string name, decimal price);
        void ChangeShippingAddress(string street, string city, string state, string zip);
        void UpdateOrderStatus(OrderStatus orderStatus);
    }
}
