using Group15.EventManager.Domain.Core.Commands;
using System;

namespace Group15.EventManager.Domain.Commands.Tickets
{
    public class DeleteTicketCommand : Command
    {
        public Guid TicketId { get; }
        public DeleteTicketCommand(Guid ticketId)
        {
            TicketId = ticketId;
        }
    }
}
