using Group15.EventManager.Domain.Models.Joint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group15.EventManager.Data.Mappings
{
    public class ApplicationUserEventMap : IEntityTypeConfiguration<ApplicationUserEvent>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserEvent> builder)
        {
            builder.ToTable("UserEvents");
            builder.HasKey(aue => new { aue.ApplicationUserId, aue.EventId });
            builder.HasOne(aue => aue.Event).WithMany(e => e.UserEvents).HasForeignKey(aue => aue.EventId);
            builder.HasOne(aue => aue.User).WithMany(u => u.UserEvents).HasForeignKey(aue => aue.ApplicationUserId);
        }
    }
}