using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;
using System;
using System.Linq;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IEventRepository : IRepository<Event>
    {
        IQueryable<Event> GetActiveEvents();
        IQueryable<Event> GetEventsByRegion(Guid regionId);
        IQueryable<Event> GetEventsByRegionAndCity(Guid regionId, Guid cityId);
        IQueryable<Event> GetEventsForUser(Guid userId);
        Event GetSingleEvent(Guid eventId);
        void UpdateEvent(Event _event);
    }
}
