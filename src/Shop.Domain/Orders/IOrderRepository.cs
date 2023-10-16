using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Shop.Orders
{
    public interface IOrderRepository : IRepository<Order,Guid>
    {
        Task <List<Order>> GetListAsync();
    }
}
