using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int TechnicianId { get; set; }
        public AppUser AppUser { get; set; } = null!;
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;
        public int Price { get; set; }
    }
}
