﻿using EFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_CodeFirst.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            // TABLE NAME
            builder.ToTable("Title");

            // PRIMARY KEY
            builder.HasKey(t => t.TitleId);

            // NOT NULL
            builder.Property(t => t.Name).IsRequired();

            // CONSTRAINTS
            builder.Property(t => t.Name).HasMaxLength(50);
        }
    }
}
