using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Group15.EventManager.Data.Mappings
{
    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");
            builder.HasKey(_event => _event.Id);

            builder.HasData(new
            {
                Id = new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"),
                Name = "Vinsmagning i hyggelige omgivelser",
                Description = "Eventet kommer til at foregå i Odense kl. 16:00, hvor man vil få tilbudt forfriskninger og vin til maden",
                Price = 700.00,
                EventDate = new DateTime(2022, 12, 24, 14, 30, 00),
                LastBookingDate = new DateTime(2022, 12, 12, 12, 00, 00),
                EndEventDate = new DateTime(2022, 12, 24, 20, 00, 00),
                Image = new byte[] { 0x00 },
                PayOnline = true,
                MaxCustomerLimit = 200,
                MinCustomerAmount = 50,
                AttendanceId = new Guid("2300cd37-5bf0-436a-1136-08d798f22ccd"),
                AddressId = new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"),
                MarkerId = new Guid("847fea10-80f0-49a0-8997-409eafdb5892"),
                CityId = new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                EmployeeId = new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"),
                FoodId = new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"),
                RegionId = new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"),
                StoreId = new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"),
                CreatedDate = new DateTime(2019, 12, 01)
            });
        }
    }
}
