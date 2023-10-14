using Shop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Shop
{
    public class ProductStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductStoreDataSeederContributor(IRepository<Product,Guid> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _productRepository.GetCountAsync() <= 0) {
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "Mobile",
                        Description = "Smartphone",
                        Price = 2345
                    },autoSave:true);
                await _productRepository.InsertAsync(
                   new Product
                   {
                       Name = "Tab",
                       Description = "Samsung",
                       Price = 2346
                   }, autoSave: true);
            }
        }
    }
}
