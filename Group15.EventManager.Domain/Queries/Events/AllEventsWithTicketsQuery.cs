using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;
using System.Linq;

namespace Group15.EventManager.Domain.Queries.Events
{
    public class AllEventsWithTicketsQuery : Query<IQueryable<Event>>
    {
        public Guid UserId { get; }
        public AllEventsWithTicketsQuery(Guid userId)
        {
            UserId = userId;
        }
    }
}
