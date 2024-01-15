using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public int Quantity { get; set; }
        public ICollection<ServiceRequest>? ServiceRequests { get; set; }

    }
}
