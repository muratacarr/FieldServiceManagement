using FieldServiceManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Repository.Seed
{
    public class StatusSeed : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status { Id = 1, Name = "Açık" },
                new Status { Id = 2, Name = "Onayda" },
                new Status { Id = 3, Name = "Atama Bekliyor" },
                new Status { Id = 4, Name = "Teknisyende" },
                new Status { Id = 5, Name = "Adrese Geliyor" },
                new Status { Id = 6, Name = "Çalışma Yapılıyor" },
                new Status { Id = 7, Name = "Ödeme Bekliyor" },
                new Status { Id = 8, Name = "Tamamlandı" },
                new Status { Id = 9, Name = "Kapandı" }
                );
        }
    }
}
