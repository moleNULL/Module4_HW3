using EFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_CodeFirst.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // PRIMARY KEY
            builder.HasKey(e => e.EmployeeId);

            // NOT NULL
            builder.Property(e => e.FirstName).IsRequired();
            builder.Property(e => e.LastName).IsRequired();

            // ?
            builder.Property(e => e.FirstName).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(50);
            // builder.Property(e => e.HiredDate).HasColumnType("datetime").HasMaxLength(7);

            // FOREIGN KEY and relationships: one to many | many to many
            builder.HasOne(e => e.Title).WithMany(t => t.Employees).HasForeignKey(e => e.TitleId);
            builder.HasOne(e => e.Office).WithMany(o => o.Employees).HasForeignKey(e => e.OfficeId);
        }
    }
}
