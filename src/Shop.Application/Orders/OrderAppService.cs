using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Orders
{
    public class OrderAppService :ShopAppService, IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderManager _OrderManager;
        public OrderAppService(
            IOrderRepository orderRepository,
            OrderManager orderManager)
        {
            _orderRepository = orderRepository;
            _OrderManager = orderManager;
        }

        

        public async Task<OrderDto> CreateAsync(CreateOrderDto input)
        {
            var order = await _OrderManager.CreateAsync(
                input.ProductId,
                input.CustomerName,
                input.OrderDate
                
                );
                
               
            await _orderRepository.InsertAsync( order );
            return ObjectMapper.Map<Order,OrderDto>(order);
        }

        public async Task<OrderDto> GetAsync(Guid id)
        {
            var order = await _orderRepository.GetAsync( id );
            return ObjectMapper.Map<Order, OrderDto>(order);
        }
    }
}
