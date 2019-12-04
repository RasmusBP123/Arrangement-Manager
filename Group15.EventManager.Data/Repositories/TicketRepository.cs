using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
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
    }
}
