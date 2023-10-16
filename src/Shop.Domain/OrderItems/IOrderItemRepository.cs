using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Shop.OrderItems
{
    public interface IOrderItemRepository : IRepository<OrderItem,Guid>
    {
        Task<List<OrderItem>> GetListAsync();
    }
}
