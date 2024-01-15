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
    public class ServiceRequestConfiguration : IEntityTypeConfiguration<ServiceRequest>
    {
        public void Configure(EntityTypeBuilder<ServiceRequest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.AppUser).WithMany(x=>x.ServiceRequests).HasForeignKey(x=>x.CustomerId);
            builder.HasOne(x => x.Product).WithMany(x => x.ServiceRequests).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Payment).WithOne(x => x.ServiceRequest).HasForeignKey<Payment>(x => x.ServiceRequestId);
            builder.HasOne(x => x.CustomerFeedback).WithOne(x => x.ServiceRequest).HasForeignKey<CustomerFeedback>(x => x.ServiceRequestId);
        }
    }
}
