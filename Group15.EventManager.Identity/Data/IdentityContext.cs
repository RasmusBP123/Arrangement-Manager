using Group15.EventManager.Data.Mappings;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

namespace Group15.EventManager.Identity.Data
{
    public class IdentityContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        private readonly IHostEnvironment _env;

        public IdentityContext(DbContextOptions options, IHostEnvironment env) : base(options)
        {
            _env = env;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().Ignore(user => user.TwoFactorEnabled)
                                             .Ignore(user => user.LockoutEnabled)
                                             .Ignore(user => user.LockoutEnd)
                                             .Ignore(user => user.EmailConfirmed)
                                             .Ignore(user => user.AccessFailedCount);

            builder.ApplyConfiguration(new ApplicationUserEventMap());
            builder.Entity<ApplicationUser>().ToTable("Users");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
