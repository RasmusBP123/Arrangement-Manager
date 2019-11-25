using Group15.EventManager.Domain.Core.Models;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using System;

namespace Group15.EventManager.Domain.Models.Joint
{
    public class ApplicationUserEvent
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; }
    }
}
