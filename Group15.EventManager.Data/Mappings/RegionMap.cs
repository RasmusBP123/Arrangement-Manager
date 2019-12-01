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
                    Id = Guid.NewGuid()
                }); ;
        }
    }
}
