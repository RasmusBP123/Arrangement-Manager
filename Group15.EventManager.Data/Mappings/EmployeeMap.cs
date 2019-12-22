using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Group15.EventManager.Data.Mappings
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);

            builder.HasData(new
            {
                Id = new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"),
                Name = "Torsten Jakobsen",
                StoreId = new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"),
                CreatedDate = new DateTime(2019, 12, 01),
            });
        }
    }
}
