﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QLBanMyPham.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Configurations
{
    public class CartConfigurations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.CartID);
            builder.Property(x => x.CartID).ValueGeneratedOnAdd();
            builder.HasOne(x => x.User).WithOne(x => x.Cart).HasForeignKey<Cart>(x => x.CartID).IsRequired();
            builder.HasMany(x => x.CartItems).WithOne(x => x.Cart).HasForeignKey(x => x.CartID).IsRequired();
        }

    }
}
