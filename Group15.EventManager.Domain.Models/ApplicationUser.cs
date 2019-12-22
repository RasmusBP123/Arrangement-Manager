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
        public ICollection<ApplicationUserEvent> UserEvents { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<ApplicationUserGroup> Groups { get; set; }
    }
}
