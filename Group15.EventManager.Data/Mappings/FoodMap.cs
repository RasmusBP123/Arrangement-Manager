using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Mappings
{
    public class FoodMap : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Foods");
            builder.HasKey(food => food.Id);

            builder.HasData(new
            {
                Id = new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"),
                Name = "Stegt and",
                Price = 249.95,
                CreatedDate = new DateTime(2019, 12, 01)
            });
        }
    }
}
