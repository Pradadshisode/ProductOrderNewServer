using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Shop.OrderItems
{
    public interface IOrderItemAppService : IApplicationService
    {
        Task<OrderItemDto> GetAsync(Guid id);
        Task<OrderItemDto> CreateAsync(OrderItemDto input);
    }
}
