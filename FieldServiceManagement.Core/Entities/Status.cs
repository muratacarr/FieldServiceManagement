using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Entities
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ServiceRequest>? ServiceRequests { get; set; }
    }
}
