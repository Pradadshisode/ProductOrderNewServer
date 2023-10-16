using AutoMapper;
using Shop.OrderItems;
using Shop.Orders;
using Shop.Products;

namespace Shop;

public class ShopApplicationAutoMapperProfile : Profile
{
    public ShopApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderItemDto>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
