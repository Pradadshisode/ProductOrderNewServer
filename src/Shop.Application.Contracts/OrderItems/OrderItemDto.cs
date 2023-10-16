using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.OrderItems
{
    public class OrderItemDto
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public float Price { get; set; }
    }
}
