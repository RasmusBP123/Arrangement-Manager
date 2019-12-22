using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;

namespace Group15.EventManager.Domain.Queries.Events
{
    public class SingleEventQuery : Query<Event>
    {
        public Guid Id { get; }

        public SingleEventQuery(Guid id)
        {
            Id = id;
        }
    }
}
