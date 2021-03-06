﻿using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models.Auth;
using System;

namespace Group15.EventManager.Domain.Queries.Users
{
    public class SingleUserQuery : Query<ApplicationUser>
    {
        public Guid UserId { get; }
        public SingleUserQuery(Guid userId)
        {
            UserId = userId;
        }

    }
}
