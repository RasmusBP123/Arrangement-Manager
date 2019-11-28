﻿using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using System;

namespace Group15.EventManager.Domain.Commands.Users
{
    public class AddUserToEventCommand : Command
    {
        public Guid UserId { get; }
        public Guid EventId { get; }

        public AddUserToEventCommand(Guid userId, Guid eventId)
        {
            UserId = userId;
            EventId = eventId;
        }
    }
}
