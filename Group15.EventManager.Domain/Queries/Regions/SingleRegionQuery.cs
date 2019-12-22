using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;

namespace Group15.EventManager.Domain.Queries.Regions
{
    public class SingleRegionQuery : Query<Region>
    {
        public Guid RegionId { get; set; }
        public SingleRegionQuery(Guid regionId)
        {
            RegionId = regionId;
        }
    }
}
