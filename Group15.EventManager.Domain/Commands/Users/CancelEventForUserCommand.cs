using Group15.EventManager.Domain.Core.Commands;
using System;

namespace Group15.EventManager.Domain.Commands.Users
{
    public class CancelEventForUserCommand : Command
    {
        public Guid UserId { get; }
        public Guid EventId { get; }

        public CancelEventForUserCommand(Guid userId, Guid eventId)
        {
            UserId = userId;
            EventId = eventId;
        }
    }
}
