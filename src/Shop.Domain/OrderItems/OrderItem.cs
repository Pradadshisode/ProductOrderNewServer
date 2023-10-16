using Shop.Orders;
using Shop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Shop.OrderItems
{
    public class OrderItem : Entity<Guid>
    {
        public OrderItem(Guid id, string customerName, DateTime orderDate, Guid productId, string description, float price, string name) : base(id)
        {
        }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }
        
    }
}
