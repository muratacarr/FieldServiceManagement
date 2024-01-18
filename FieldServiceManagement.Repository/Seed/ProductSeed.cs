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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, ProductName = "Lavabo Bataryası", Price = 2000, Quantity = 100 },
                new Product { Id = 2, ProductName = "Banyo Bataryası", Price = 3000, Quantity = 200 },
                new Product { Id = 3, ProductName = "Duş Bataryası", Price = 4000, Quantity = 600 },
                new Product { Id = 4, ProductName = "Küvet Bataryası", Price = 7000, Quantity = 500 },
                new Product { Id = 5, ProductName = "Bide Bataryaları", Price = 2000, Quantity = 400 },
                new Product { Id = 6, ProductName = "Termostatik Bataryalar", Price = 9000, Quantity = 200 },
                new Product { Id = 7, ProductName = "Musluklar", Price = 1000, Quantity = 50 }
            );
        }
    }
}
