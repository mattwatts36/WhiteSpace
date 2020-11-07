using System.Collections.Generic;

namespace Web.Models
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public string Ref { get; set; }
        public IList<OrderItem> Items { get; set; }
    }
}