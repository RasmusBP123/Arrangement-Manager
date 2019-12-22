using System;

namespace Group15.EventManager.Shared.Users
{
    public class AddUserToEventViewModel
    {
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        public int TicketAmount { get; set; }
    }
}
