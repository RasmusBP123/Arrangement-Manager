using Group15.EventManager.Domain.Models.Joint;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models.Auth
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public virtual IList<ApplicationUserEvent> UserEvents { get; set; }
        public ApplicationUser() : base()
        {
            Id = Guid.NewGuid();
        }
    }
}
