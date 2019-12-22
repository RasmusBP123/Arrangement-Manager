using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;
using System.Linq;

namespace Group15.EventManager.Domain.Queries.Events
{
    public class AllEventsForUserQuery : Query<IQueryable<Event>>
    {
        public Guid UserId { get; set; }
        public AllEventsForUserQuery(Guid userId)
        {
            UserId = userId;
        }
    }
}
