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
    public class ProductAttributesConfigurations : IEntityTypeConfiguration<ProductAttributes>
    {
        public void Configure(EntityTypeBuilder<ProductAttributes> builder)
        {
            builder.ToTable("ProductAttributes");
            builder.HasKey(x => x.ProductAttributesID);
            builder.Property(x => x.ProductAttributesID).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Products).WithMany(x => x.ProductAttributes).HasForeignKey(x => x.ProductID).IsRequired();
        }

    }
}
