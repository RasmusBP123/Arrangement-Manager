using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Group15.EventManager.Data.Mappings
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.HasKey(city => city.Id);

            builder.HasOne(city => city.Region).WithMany(region => region.Cities);

            builder.HasData(
                new
                {
                    Id = new Guid("038d1fee-4610-4f8f-acf5-d35d2f24d72f"),
                    Name = "Herning",
                    RegionId = new Guid("0d096733-5437-4c53-8f3d-0e815d3753b3"),
                    Zipcode = 7429,
                    CreatedDate = new DateTime(2019, 12, 01)
                });
            builder.HasData(
                new
                {
                    Id = new Guid("6daf7bfe-850b-4bdd-87c5-5cf5cc2160dd"),
                    Name = "Aalborg",
                    RegionId = new Guid("4c68ec57-cfed-4b52-be86-6349d47f9a74"),
                    Zipcode = 9000,
                    CreatedDate = new DateTime(2019, 12, 01)
                });
            builder.HasData(
                    new
                    {
                        Id = new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                        Name = "Fyn",
                        RegionId = new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"),
                        Zipcode = 5000,
                        CreatedDate = new DateTime(2019, 12, 01)
                    });
            builder.HasData(
                    new
                    {
                        Id = new Guid("0a0e4d03-66af-4121-8de0-707d12beaeed"),
                        Name = "Slagelse",
                        RegionId = new Guid("2469efa8-72a6-490f-bf5a-b434e672bc78"),
                        Zipcode = 4200,
                        CreatedDate = new DateTime(2019, 12, 01)
                    });
            builder.HasData(
                    new
                    {
                        Id = new Guid("1d3ffeaa-3d1f-4920-9ffa-310f61b8dc41"),
                        Name = "København",
                        RegionId = new Guid("808bb796-576a-46d8-a53f-cd52324d9705"),
                        Zipcode = 2100,
                        CreatedDate = new DateTime(2019, 12, 01)
                    });
        }
    }
}
