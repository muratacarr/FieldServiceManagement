using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Entities
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public AppUser AppUser { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public DateTime RequestDate { get; set; }
        public int ZoneId { get; set; }
        public string IssueDescription { get; set; } = null!;
        public string Status { get; set; } = null!;
        public ICollection<JobAssignment>? JobAssignments { get; set; }
        public CustomerFeedback? CustomerFeedback { get; set; }
        public Payment? Payment { get; set; }
    }
}
