﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core.Entities
{
    public class Product: BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
    }
}
