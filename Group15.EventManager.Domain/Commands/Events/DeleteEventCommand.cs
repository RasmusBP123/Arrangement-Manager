using Group15.EventManager.Domain.Core.Commands;
using System;

namespace Group15.EventManager.Domain.Commands.Events
{
    public class DeleteEventCommand : Command
    {
        public Guid EventId { get; set; }

        public DeleteEventCommand(Guid eventId)
        {
            EventId = eventId;
        }
    }
}
