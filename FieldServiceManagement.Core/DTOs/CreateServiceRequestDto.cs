using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class CreateServiceRequestDto
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime RequestDate { get; set; }
        public int ZoneId { get; set; }
        public string IssueDescription { get; set; } = null!;
        public int StatusId { get; set; }
    }
}
