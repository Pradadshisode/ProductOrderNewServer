﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Shop.Products
{
    public class ProductDto : AuditedEntityDto<Guid>
    {
        public int ProductId {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }
    }
}
