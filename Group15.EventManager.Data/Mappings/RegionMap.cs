using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Mappings
{
    public class RegionMap : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Regions");
            builder.HasKey(region => region.Id);
            builder.HasMany(region => region.Cities).WithOne(city => city.Region);

            builder.HasData(
                new Region
                {
                    Id = new Guid("0d096733-5437-4c53-8f3d-0e815d3753b3"),
                    Name = "Midtjylland",
                });
            builder.HasData(
                new Region
                {
                    Id = new Guid("4c68ec57-cfed-4b52-be86-6349d47f9a74"),
                    Name = "Nordjylland",
                });
            builder.HasData(
                new Region
                {
                    Id = new Guid("2469efa8-72a6-490f-bf5a-b434e672bc78"),
                    Name = "Sjælland",
                });
        }
    }
}
