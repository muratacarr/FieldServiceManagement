using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class ServiceRequestDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public AppUserForServiceRequestDto AppUser { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public DateTime RequestDate { get; set; }
        public string IssueDescription { get; set; }
        public int StatusId { get; set; }
        public StatusDto Status { get; set; }
    }
}
