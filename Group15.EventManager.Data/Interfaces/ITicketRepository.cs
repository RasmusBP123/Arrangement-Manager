using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group15.EventManager.Data.Interfaces
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        IQueryable<Ticket> GetAllTicketsFromUser(Guid userId);
    }
}
