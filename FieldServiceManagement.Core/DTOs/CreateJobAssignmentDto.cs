using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class CreateJobAssignmentDto
    {
        public int ServiceRequestId { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}
