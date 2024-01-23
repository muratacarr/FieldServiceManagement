﻿using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
