using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
