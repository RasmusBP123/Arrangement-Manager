using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasData(new
            {
                Id = new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"),
                RoadName = "Bredgade",
                RoadNumber = 1,
                CreatedDate = new DateTime(2019, 12, 01)
            });
        }
    }
}
