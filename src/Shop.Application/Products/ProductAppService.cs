using Shop.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Shop.Products
{
    public class ProductAppService : CrudAppService<Product,ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
            GetPolicyName = ShopPermissions.Products.Default;
            GetListPolicyName = ShopPermissions.Products.Default;
            CreatePolicyName = ShopPermissions.Products.Create;
            UpdatePolicyName = ShopPermissions.Products.Edit;
            DeletePolicyName = ShopPermissions.Products.Delete;
        }
    }
}
