using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Mappings
{
    public class MarkerMap : IEntityTypeConfiguration<Marker>
    {
        public void Configure(EntityTypeBuilder<Marker> builder)
        {
            builder.ToTable("Markers");
            builder.HasKey(mark => mark.Id);


            builder.HasData( new //Event marker
            {
                Id = new Guid("847fea10-80f0-49a0-8997-409eafdb5892"),
                X = 10.369267,
                Y = 55.427731,
                CreatedDate = new DateTime(2019, 12, 12),
            }, new //Store marker
            {
                Id = new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"),
                X = 10.379875,
                Y = 55.394003,
                CreatedDate = new DateTime(2019, 12, 12),
            });
        }
    }
}
