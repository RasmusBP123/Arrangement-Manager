using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Group15.EventManager.Data.Mappings
{
    public class AttendanceMap : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.ToTable("Attendance");
            builder.HasKey(attendance => attendance.Id);

            builder.HasData(new 
            {
                Id = new Guid("2300cd37-5bf0-436a-1136-08d798f22ccd"),
                Invited = 0,
                NotRegistred = 0,
                Registered = 0,
                MaxCustomerLimit = 100,
                MinCustomerAmount = 10,
                Finished = false,
                CreatedDate = new DateTime(2020, 01,01),
            });
        }
    }
}
