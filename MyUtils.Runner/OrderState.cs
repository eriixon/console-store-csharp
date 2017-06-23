using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtils.Runner
{
    public class OrderState : IOrderState
    {
        public int OrderId { get ; set ; }
        public Address ShippingAddress { get; set; }
        public List<LineItem> LineItems { get; set; }
        public OrderStatus Status { get; set; }

        public OrderState()
        {
            LineItems = new List<LineItem>();
            Status = OrderStatus.Ordered;
        }

        public void AddLineItem(int productId, string name, decimal price)
        {
            var newLineItem = new LineItem(productId, name, price);
            LineItems.Add(newLineItem);
        }

        public void ChangeShippingAddress(string street, string city, string state, string zip)
        {
            ShippingAddress = new Address(street, city, state, zip);
        }

        public void UpdateOrderStatus(OrderStatus orderStatus)
        {
            Status = orderStatus;
        }
    }
}
