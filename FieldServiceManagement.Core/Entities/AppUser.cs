using FieldServiceManagement.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int ZoneId { get; set; }
        public Zone Zone { get; set; } = null!;
        public string? City { get; set; }
        public ICollection<ServiceRequest>? ServiceRequests { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public ICollection<JobAssignment>? JobAssignments { get; set; }
        public UserRefreshToken? UserRefreshToken { get; set; }
    }
}
