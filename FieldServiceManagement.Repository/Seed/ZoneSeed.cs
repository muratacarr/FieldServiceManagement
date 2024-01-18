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
    public class ZoneSeed : IEntityTypeConfiguration<Zone>
    {
        public void Configure(EntityTypeBuilder<Zone> builder)
        {
            builder.HasData(
                new Zone { Id = 1, Name = "Buca" }, 
                new Zone { Id = 2, Name = "Çiğli" },
                new Zone { Id = 3, Name = "Bornova" }
            );
        }
    }
}
