using Group15.EventManager.Domain.Models.Auth;
using System;

namespace Group15.EventManager.Domain.Models.Joint
{
    public class ApplicationUserGroup
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }
}
