using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Group15.EventManager.Data.Mappings
{
    public class StoreMap : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("Stores");
            builder.HasKey(store => store.Id);

            builder.HasData(new
            {
                Id = new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"),
                Name = "Odense Vinbutik",
                RegionId = new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"),
                CityId = new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                AddressId = new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"),
                MarkerId = new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"),
                CreatedDate = new DateTime(2019, 12, 01)
            });
        }
    }
}
