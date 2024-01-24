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
                new Status { Id = 1, Name = "Açık", Percent = 10, ShowTechnician = false, Color = "#fcbdbd" },
                new Status { Id = 2, Name = "Onaylandı", Percent = 20, ShowTechnician = false, Color = "#fff494" },
                new Status { Id = 3, Name = "Atama Bekliyor", Percent = 30, ShowTechnician = false, Color = "#fff494" },
                new Status { Id = 4, Name = "Teknisyende", Percent = 40, ShowTechnician = true, Color = "#fff494" },
                new Status { Id = 5, Name = "Adrese Geliyor", Percent = 50, ShowTechnician = true, Color = "#c2dfff" },
                new Status { Id = 6, Name = "Çalışma Yapılıyor", Percent = 60, ShowTechnician = true, Color = "#c2dfff" },
                new Status { Id = 7, Name = "Ödeme Bekliyor", Percent = 70, ShowTechnician = true, Color = "#c2dfff" },
                new Status { Id = 8, Name = "Tamamlandı", Percent = 80, ShowTechnician = true, Color = "#d2f5b0" },
                new Status { Id = 9, Name = "Oylama Bekliyor", Percent = 90, ShowTechnician = false, Color = "#d2f5b0" },
                new Status { Id = 10, Name = "Kapandı", Percent = 100, ShowTechnician = false, Color = "#d2f5b0" },
                new Status { Id = 11, Name = "Reddedildi", Percent = 0, ShowTechnician = false, Color = "#c9ccc4" }
                );
        }
    }
}
