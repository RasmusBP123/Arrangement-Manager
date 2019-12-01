using Group15.EventManager.Domain.Models.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Mappings
{
    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
             builder.ToTable("Users");
             builder.Ignore(user => user.TwoFactorEnabled)
                    .Ignore(user => user.LockoutEnabled)
                    .Ignore(user => user.LockoutEnd)
                    .Ignore(user => user.EmailConfirmed)
                    .Ignore(user => user.AccessFailedCount);
        }
    }
}
