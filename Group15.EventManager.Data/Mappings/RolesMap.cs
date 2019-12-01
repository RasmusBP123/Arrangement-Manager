using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Mappings
{
    public class RolesMap : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(new
            {
                Id = new Guid("f2209255-92ed-4e3a-9368-31736af7f935"),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = "62b0f3e4-fa81-4b33-a5b4-9c21e8aa577f",
                CreatedDate = new DateTime(2019, 12, 01)
            });
            builder.HasData(new
            {
                Id = new Guid("6519cc1b-cd18-4898-a7bd-959d826ff413"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "9be42a72-8ca8-42fb-a61c-bc8e323f523e",
                CreatedDate = new DateTime(2019, 12, 01)
            });
        }
    }
}
