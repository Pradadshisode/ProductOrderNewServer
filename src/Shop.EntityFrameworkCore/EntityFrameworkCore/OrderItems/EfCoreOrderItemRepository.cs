using Microsoft.EntityFrameworkCore;
using Shop.OrderItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Shop.EntityFrameworkCore.OrderItems
{
    public class EfCoreOrderItemRepository : EfCoreRepository<ShopDbContext, OrderItem, Guid>, IOrderItemRepository
    {
        public EfCoreOrderItemRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base (dbContextProvider) 
        {
        }
        public async Task<List<OrderItem>> GetListAsync()
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ToListAsync();
        }
    }

    
}
