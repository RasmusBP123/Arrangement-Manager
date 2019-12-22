using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;
using System.Linq;

namespace Group15.EventManager.Domain.Queries.Events.Filters
{
    public class AllEventsByRegionQuery : Query<IQueryable<Event>>
    {
        public Guid RegionId { get; }
        public AllEventsByRegionQuery(Guid regionId)
        {
            RegionId = regionId;
        }
    }
}
