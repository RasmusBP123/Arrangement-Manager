using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;
using System;

namespace Group15.EventManager.Data.Interfaces
{
    public interface ICityRepository : IRepository<City>
    {
        City GetSingleCity(Guid cityId);
    }
}
