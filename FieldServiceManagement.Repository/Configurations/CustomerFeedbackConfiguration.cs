using FieldServiceManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FieldServiceManagement.Repository.Configurations
{
    public class CustomerFeedbackConfiguration : IEntityTypeConfiguration<CustomerFeedback>
    {
        public void Configure(EntityTypeBuilder<CustomerFeedback> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Rating).HasColumnType("decimal(3,1)");
        }
    }
}
