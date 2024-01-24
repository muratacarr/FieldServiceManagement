using FieldServiceManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Repository.Configurations
{
    public class JobAssignmentConfiguration : IEntityTypeConfiguration<JobAssignment>
    {
        public void Configure(EntityTypeBuilder<JobAssignment> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne(x=>x.ServiceRequest).WithMany(x=>x.JobAssignments).HasForeignKey(x=>x.ServiceRequestId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.AppUserTechnician).WithMany(x => x.JobAssignments).HasForeignKey(x => x.TechnicianId);
        }
    }
}
