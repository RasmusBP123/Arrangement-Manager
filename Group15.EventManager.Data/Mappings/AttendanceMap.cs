using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group15.EventManager.Data.Mappings
{
    public class AttendanceMap : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.ToTable("Attendance");
            builder.HasKey(attendance => attendance.Id);
        }
    }
}
