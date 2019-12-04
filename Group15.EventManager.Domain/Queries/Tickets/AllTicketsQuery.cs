using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group15.EventManager.Domain.Queries.Tickets
{
    public class AllTicketsQuery : Query<IQueryable<Ticket>>
    {
        public Guid UserId { get; }
        public AllTicketsQuery(Guid userId)
        {
            UserId = userId;
        }
    }
}
