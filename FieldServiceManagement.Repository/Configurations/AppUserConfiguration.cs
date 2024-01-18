using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Repository.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(x => x.UserRefreshToken).WithOne(x => x.AppUser).HasForeignKey<UserRefreshToken>(x => x.AppUserId);
            builder.HasOne(x => x.Zone).WithMany(x => x.AppUsers).HasForeignKey(x => x.ZoneId);
        }
    }
}
