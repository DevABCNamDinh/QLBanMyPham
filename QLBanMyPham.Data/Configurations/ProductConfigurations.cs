using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QLBanMyPham.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.ProductID);
            builder.Property(x => x.ProductID).ValueGeneratedOnAdd();
            builder.HasOne(x => x.ProductType).WithMany(x => x.Products).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasOne(x => x.Origin).WithMany(x => x.Products).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasMany(x => x.ProductAttributes).WithOne(x => x.Products).HasForeignKey(x => x.ProductID).IsRequired();
        }

    }
}
