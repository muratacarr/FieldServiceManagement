using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class JobAssignmentDto
    {
        public int Id { get; set; }
        public int? TechnicianId { get; set; }
        public AppUserForServiceRequestDto? AppUserTechnician { get; set; }
        public int ServiceRequestId { get; set; }
        public ServiceRequestDto ServiceRequest { get; set; } = null!;
        public DateTime AssignmentDate { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? TakeJobDate { get; set; }
        public DateTime? FinishJobDate { get; set; }
    }
}
