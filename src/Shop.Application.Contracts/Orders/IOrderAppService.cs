using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Shop.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        Task<OrderDto>GetAsync(Guid id);
        
        Task<OrderDto> CreateAsync(CreateOrderDto input);
    }
}
