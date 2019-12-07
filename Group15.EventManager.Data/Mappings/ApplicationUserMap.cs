using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
                    .Ignore(user => user.PhoneNumberConfirmed)
                    .Ignore(user => user.EmailConfirmed)
                    .Ignore(user => user.AccessFailedCount);

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(new
            {
                Id = new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                UserName = "adminDev@hotmail.com",
                NormalizedUserName = "ADMINDEV@HOTMAIL.COM",
                Email = "adminDev@hotmail.coM",
                NormalizedEmail = "ADMINDEV@HOTMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "Horse123!"),
                SecurityStamp ="f4572cb1-6f71-46fd-8260-0baea7287367",
                ConcurrencyStamp = "bd5b9857-9d78-4f9d-81e3-28569973e0a2",
                PhoneNumber = "28929173",
                FirstName = "Rasmus",
                LastName = "Petersen",
                CreatedDate = new DateTime(2019, 08, 12)
            });
        }
    }
}
