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
    public class OriginConfigurations : IEntityTypeConfiguration<Origin>
    {
        public void Configure(EntityTypeBuilder<Origin> builder)
        {
            builder.ToTable("Origins");
            builder.HasKey(x => x.OriginID);
            builder.Property(x => x.OriginID).ValueGeneratedOnAdd();
            builder.HasMany(x => x.Products).WithOne(x => x.Origin).HasForeignKey(x => x.ProductID).IsRequired();
        }

    }
}
