using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Domain.Models.Joint;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Group15.EventManager.Data.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(SqlContext context) : base(context)
        {
        }

        public IQueryable<Event> GetActiveEvents()
        {
            var events = Db.Set<Event>().Include(_event => _event.Region)
                                        .Where(_event => _event.EventDate >= DateTime.Today);
            return events;
        }

        public IQueryable<Event> GetEventsByRegion(Guid regionId)
        {
            var events = Db.Set<Event>().Include(_event => _event.Region)
                                        .Where(_event => _event.Region.Id == regionId)
                                        .Where(_event => _event.EventDate >= DateTime.Today);
            return events;
        }

        public IQueryable<Event> GetEventsByRegionAndCity(Guid regionId, Guid cityId)
        {
            var events = Db.Set<Event>().Include(_event => _event.Region)
                                        .Where(_event => _event.Region.Id == regionId && _event.City.Id == cityId)
                                        .Where(_event => _event.EventDate >= DateTime.Today);
            return events;
        }

        public IQueryable<Event> GetEventsForUser(Guid userId)
        {
            var user = Db.Set<ApplicationUser>().FirstOrDefault(user => user.Id == userId);
            var userEvents = Db.Set<ApplicationUserEvent>().Include(ue => ue.Event).Where(ue => ue.ApplicationUserId == userId);
            var events = userEvents.Select(ue => ue.Event);
            return events;
        }

        public Event GetSingleEvent(Guid eventId)
        {
            var _event = Db.Set<Event>().Include(e => e.Food)
                                        .FirstOrDefault(e => e.Id == eventId);
            return _event;
        }

        public override void Add(Event entity)
        {
            Db.Attach(entity.City);
            Db.Attach(entity.Region);
            Db.Attach(entity.Address);
            base.Add(entity);
        }

        public void UpdateEvent(Event _event)
        {
            var existingEvent = Db.Set<Event>().FirstOrDefault(e => e.Id == _event.Id);
            existingEvent = _event;
            Db.Attach(existingEvent).State = EntityState.Modified;
        }
    }
}
