using System;

namespace Shop.Orders
{
    public class CreateOrderDto
    {
        public Guid ProductId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}