using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;
using System.Linq;

namespace Group15.EventManager.Domain.Queries.Events.Filters
{
    public class AllEventsByRegionAndCityQuery : Query<IQueryable<Event>>
    {
        public Guid RegionId { get; }
        public Guid CityId { get; }
        public AllEventsByRegionAndCityQuery(Guid regionId, Guid cityId)
        {
            RegionId = regionId;
            CityId = cityId;
        }
    }
}
