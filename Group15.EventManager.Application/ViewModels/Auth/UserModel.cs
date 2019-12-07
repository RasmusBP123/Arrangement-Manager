using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Application.ViewModels.Auth
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
