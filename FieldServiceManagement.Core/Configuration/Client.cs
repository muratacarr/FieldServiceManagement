﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Configuration
{
    public class Client
    {
        public int Id { get; set; }
        public string Secret { get; set; } = null!;
        public List<string> Audiences { get; set; } = null!;
    }
}
