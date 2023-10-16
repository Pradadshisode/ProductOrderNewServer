using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Shop.Orders
{
  
    public class OrderManager : DomainService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> CreateAsync(Guid productId, string customerName,DateTime OrderDate)
        {
            return new Order(productId, customerName, OrderDate);
        }
    }
}
