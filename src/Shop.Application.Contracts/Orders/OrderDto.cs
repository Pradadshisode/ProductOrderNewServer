using System;
using Volo.Abp.Application.Dtos;

namespace Shop.Orders
{
    public class OrderDto : EntityDto<Guid>
    {

        public Guid ProductId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}