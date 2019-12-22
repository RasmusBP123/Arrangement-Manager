using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Group15.EventManager.Data.Mappings
{
    public class GroupMap : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");
            builder.HasKey(g => g.Id);

            builder.HasData(new
            {
                Id = new Guid("4bca98a6-3cd0-49da-a947-02ad2ef8cdf5"),
                Name = "Basic",
                Discount = 30.0,
                CreatedDate = new DateTime(2019, 12, 22),
            });

            builder.HasData(new
            {
                Id = new Guid("cf113457-a62f-4ed5-ae65-d5d4ebc09537"),
                Name = "Member",
                Discount = 40.0,
                CreatedDate = new DateTime(2019, 12, 22),
            });

            builder.HasData(new
            {
                Id = new Guid("0daeaea2-2e4e-49f7-be7b-d61724c60971"),
                Name = "Business",
                Discount = 45.0,
                CreatedDate = new DateTime(2019, 12, 22),
            });

            builder.HasData(new
            {
                Id = new Guid("dba67215-9771-457d-9698-d7dc708a00e7"),
                Name = "Premium",
                Discount = 55.0,
                CreatedDate = new DateTime(2019, 12, 22),
            });
        }
    }
}
