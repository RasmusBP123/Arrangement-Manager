using Group15.EventManager.Domain.Models.Joint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group15.EventManager.Data.Mappings
{
    public class ApplicationUserGroupMap : IEntityTypeConfiguration<ApplicationUserGroup>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserGroup> builder)
        {
            builder.ToTable("UserGroups");
            builder.HasKey(aug => new { aug.ApplicationUserId, aug.GroupId });
            builder.HasOne(user => user.User).WithMany(user => user.Groups).HasForeignKey(aug => aug.ApplicationUserId);
            builder.HasOne(group => group.Group).WithMany(group => group.Users).HasForeignKey(aug => aug.GroupId);
        }
    }
}
