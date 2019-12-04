using Group15.EventManager.Domain.Core.Models;
using Group15.EventManager.Domain.Models.Auth;
using System;

namespace Group15.EventManager.Domain.Models
{
    public class Ticket : Entity
    {
        public virtual ApplicationUser User { get; set; }
        public virtual Event Event { get; set; }
    }
}
