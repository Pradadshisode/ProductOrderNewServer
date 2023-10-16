using Microsoft.EntityFrameworkCore;
using Shop.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Shop.EntityFrameworkCore.Orders
{
    public class EfCoreOrderRepository : EfCoreRepository<ShopDbContext,Order,Guid>,IOrderRepository
    {
        public EfCoreOrderRepository(IDbContextProvider<ShopDbContext> dbContextProvider): base(dbContextProvider)
        {
            
        }

        public async Task<List<Order>> GetListAsync()
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ToListAsync();
        }
    }
}
