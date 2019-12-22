using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Group15.EventManager.Data.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(SqlContext context) : base(context)
        {
        }

        public IQueryable<Ticket> GetAllTicketsFromUser(Guid userId)
        {
            var tickets = Db.Set<Ticket>().Include(ticket => ticket.User)
                                          .Include(ticket => ticket.Event)
                                          .Where(ticket => ticket.User.Id == userId && DateTime.Now <= ticket.Event.EventDate);
            return tickets;
        }

        public void UpdateTicketsForEventAndUser(ApplicationUser user, IEnumerable<Event> _events)
        {
            foreach (var e in _events)
            {
                var _event = Db.Set<Event>().Include(e => e.Tickets).FirstOrDefault(ev => ev.Id == e.Id);

                if (e.CurrentAmountOfCustomers == _event.CurrentAmountOfCustomers) return;
                if (e.CurrentAmountOfCustomers > _event.CurrentAmountOfCustomers)
                {
                    for (int i = 0; i < e.CurrentAmountOfCustomers; i++)
                    {
                        Db.Set<Ticket>().Add(new Ticket() { Id = Guid.NewGuid(), Event = _event, User = user });
                    }
                }
                if (e.CurrentAmountOfCustomers < _event.CurrentAmountOfCustomers)
                {
                    var numberOfTicketsToBeRemoved = _event.CurrentAmountOfCustomers - e.CurrentAmountOfCustomers;
                    var ticketsToBeRemoved = Db.Set<Ticket>().Take(numberOfTicketsToBeRemoved);
                    Db.Set<Ticket>().RemoveRange(ticketsToBeRemoved);
                }
            }
        }
    }
}
