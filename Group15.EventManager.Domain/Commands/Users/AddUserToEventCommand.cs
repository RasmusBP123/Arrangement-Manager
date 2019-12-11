using Group15.EventManager.Domain.Core.Commands;
using System;

namespace Group15.EventManager.Domain.Commands.Users
{
    public class AddUserToEventCommand : Command
    {
        public Guid UserId { get; }
        public Guid EventId { get; }
        public int TicketAmount { get; set; }
        public AddUserToEventCommand(Guid userId, Guid eventId, int ticketAmount)
        {
            UserId = userId;
            EventId = eventId;
            TicketAmount = ticketAmount;
        }
    }
}
