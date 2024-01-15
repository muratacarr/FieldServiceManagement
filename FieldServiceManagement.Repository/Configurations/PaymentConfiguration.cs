using FieldServiceManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FieldServiceManagement.Repository.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.AppUser).WithMany(x=>x.Payments).HasForeignKey(x=>x.TechnicianId);
            builder.HasOne(x => x.ServiceRequest).WithOne(x => x.Payment).OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
