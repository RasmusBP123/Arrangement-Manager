using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using System;

namespace Group15.EventManager.Data.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(SqlContext context) : base(context)
        {
        }

        public City GetSingleCity(Guid cityId)
        {
            throw new NotImplementedException();
        }
    }
}
