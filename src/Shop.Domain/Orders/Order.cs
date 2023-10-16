using Shop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shop.Orders
{
    public class Order : BasicAggregateRoot<Guid>
    {
        public Product Products { get; set; }

        public Guid ProductId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        
      private Order(int productId)
        {

        }
         

        public Order(Product products, Guid productId, string customerName, DateTime orderDate)
        {
            Products = products;
            ProductId = productId;
            CustomerName = customerName;
            OrderDate = orderDate;
        }

        public Order(Guid productId, string customerName, DateTime orderDate)
        {
            ProductId = productId;
            CustomerName = customerName;
            OrderDate = orderDate;
        }
    }
}
