using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Domain.Queries.Cities
{
    public class SingleCityQuery : Query<City>
    {
        public Guid CityId { get; }
        public SingleCityQuery(Guid cityId)
        {
            CityId = cityId;
        }
    }
}
