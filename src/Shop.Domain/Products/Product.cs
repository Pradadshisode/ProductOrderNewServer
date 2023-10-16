﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shop.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }
    }
}
