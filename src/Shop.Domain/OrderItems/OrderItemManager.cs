using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.Domain.Services;

namespace Shop.OrderItems
{
    public class OrderItemManager : DomainService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemManager(IOrderItemRepository orderItemRepository)
        {
           _orderItemRepository = orderItemRepository;
        }
        public async Task<OrderItem> CreateAsync(Guid OrderId, string CustomerName, DateTime OrderDate, Guid ProductId, string Description, float Price,string Name)
        {
            return new(
                OrderId,
                CustomerName,
                OrderDate,
                ProductId,
                Description,
                Price,
                Name
                );
        }

    }
}
