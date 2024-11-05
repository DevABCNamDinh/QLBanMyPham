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
    public class ProductTypeConfigurations : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductTypes");
            builder.HasKey(x => x.ProductTypeID);
            builder.Property(x => x.ProductTypeID).ValueGeneratedOnAdd();       
            builder.HasMany(x => x.Products).WithOne(x => x.ProductType).HasForeignKey(x => x.ProductID).IsRequired();
        }

    }
}
