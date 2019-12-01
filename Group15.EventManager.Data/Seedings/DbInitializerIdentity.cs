using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Seedings
{
    public static class DbInitializerIdentity
    {
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole()
                {
                    Id = "afae762e-81e3-47f6-a3c4-8e119e8fd5f1",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "21185afa-aff7-4678-9b10-630b56ebede6"
                };
                IdentityResult result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole()
                {
                    Id = "3f6be18d-a79e-4472-bdb7-d41c005f4d6d",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "ecd9e146-ef22-4379-af2d-eaa315ad181e"
                };
                IdentityResult result = roleManager.CreateAsync(role).Result;
            }

        }
    }
}
