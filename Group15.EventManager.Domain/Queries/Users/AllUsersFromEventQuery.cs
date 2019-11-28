using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group15.EventManager.Domain.Queries.Users
{
    public class AllUsersFromEventQuery : Query<IQueryable<ApplicationUser>>
    {
        public Guid EventId { get; }
        public AllUsersFromEventQuery(Guid eventId)
        {
            EventId = eventId;
        }

    }
}
