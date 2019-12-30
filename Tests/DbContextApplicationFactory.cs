using Group15.EventManager.Data.Context;
using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public static class DbContextApplicationFactory
    {
        public static SqlContext Create()
        {
            var options = new DbContextOptionsBuilder<SqlContext>()
                             .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new SqlContext(options);

            context.Database.EnsureCreated();

            SeedTestDatabase(context);

            return context;
        }

        private static void SeedTestDatabase(SqlContext context)
        {
            context.Set<Store>().AddRange(
                new Store { Id = new Guid("30e423bd-d61f-4dd7-a04e-16edfa3d8e77"), Name = "Odense Vinspecialist" },
                new Store { Id = new Guid("228b8c8b-d8c0-4686-bf4f-154989d87c5d"), Name = "Herning Vinspecialist" },
                new Store { Id = new Guid("dec4ec7f-22fb-4ca8-838a-d827fa9168ed"), Name = "København Vinspecialist" },
                new Store { Id = new Guid("d657745f-db28-48a0-ae6b-08b7c27af0fa"), Name = "Aarhus Vinspecialist" }
                );

            context.SaveChanges();
        }

        public static void Destroy(SqlContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
