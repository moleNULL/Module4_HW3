﻿using EFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_CodeFirst.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            // TABLE NAME
            builder.ToTable("Office");

            // PRIMARY KEY
            builder.HasKey(o => o.OfficeId);

            // NOT NULL
            builder.Property(o => o.Title).IsRequired();
            builder.Property(o => o.Location).IsRequired();

            // CONSTRAINTS
            builder.Property(o => o.Title).HasMaxLength(100);
            builder.Property(o => o.Location).HasMaxLength(100);
        }
    }
}
