using Shop.Orders;
using Shop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shop.OrderItems
{
    public class OrderItemAppService : ShopAppService, IOrderItemAppService
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly OrderItemManager _orderItemManager;
        public OrderItemAppService(IOrderItemRepository orderItemRepository,OrderItemManager orderItemManager )
        {
            _orderItemManager = orderItemManager;
            _orderItemRepository = orderItemRepository;
        }

        public async Task<OrderItemDto> CreateAsync(OrderItemDto input)
        {
            var order = await _orderItemManager.CreateAsync(
                input.OrderId,
                input.CustomerName,
                input.OrderDate,
                input.ProductId,
                input.Description,
                input.Price,
                input.Name
                );
            await _orderItemRepository.InsertAsync( order );
            return ObjectMapper.Map<OrderItem, OrderItemDto>( order );
        }

        public async Task<OrderItemDto> GetAsync(Guid id)
        {
            var order = await _orderItemRepository.GetAsync(id); 
            return ObjectMapper.Map<OrderItem, OrderItemDto>( order );
        }

    }
}
