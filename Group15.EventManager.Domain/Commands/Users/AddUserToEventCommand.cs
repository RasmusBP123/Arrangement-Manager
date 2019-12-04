using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using System;
using System.Collections.Generic;

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
