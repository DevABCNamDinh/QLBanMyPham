﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLBanMyPham.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.UserID);
            builder.Property(x=> x.UserID).ValueGeneratedOnAdd();
            builder.HasMany(x=>x.Orders).WithOne(x=>x.User).HasForeignKey(x=>x.UserID).IsRequired();
            builder.HasOne(x => x.Cart).WithOne(x => x.User).HasForeignKey<User>(x => x.UserID).IsRequired();
        }
    }
}
