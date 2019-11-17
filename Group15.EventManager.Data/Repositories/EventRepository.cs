using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.Data.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }

        public IEnumerable<Event> GetActiveEvents()
        {
            var events = Db.Set<Event>().Where(_event => _event.EventDate >= DateTime.Today);
            return events;
        }

        public Event GetSingleEvent(Guid eventId)
        {
            var _event = Db.Set<Event>().Include(e => e.Customers)
                                        .Include(e => e.Employee)
                                        .Include(e => e.Food)
                                        .FirstOrDefault(e => e.Id == eventId);
            return _event;
        }
    }
}
