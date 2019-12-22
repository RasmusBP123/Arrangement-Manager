using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;

namespace Group15.EventManager.Domain.Queries.Stores
{
    public class SingleStoreQuery : Query<Store>
    {
        public Guid Id { get; }
        public SingleStoreQuery(Guid id)
        {
            Id = id;
        }
    }
}
