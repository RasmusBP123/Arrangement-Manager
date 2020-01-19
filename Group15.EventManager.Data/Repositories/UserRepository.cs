using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Domain.Models.Joint;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Group15.EventManager.Data.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        public UserRepository(SqlContext context) : base(context)
        {
        }

        public void AddUserToEvent(Guid userId, Guid eventId, int ticketAmount)
        {
            var ticketList = new List<Ticket>();
            var _event = Db.Set<Event>().FirstOrDefault(e => e.Id == eventId);
            var user = Db.Set<ApplicationUser>().FirstOrDefault(u => u.Id == userId);

            for (int i = 0; i < ticketAmount; i++)
            {
                ticketList.Add(new Ticket { Event = _event, User = user });
            }

            Db.Set<Ticket>().AddRange(ticketList);

            var userEvent = new ApplicationUserEvent() { ApplicationUserId = userId, EventId = eventId };
            Db.Set<ApplicationUserEvent>().Add(userEvent);
        }

        public IQueryable<ApplicationUser> GetAllUsersFromEvent(Guid eventId)
        {
            var userEvents = Db.Set<ApplicationUserEvent>().Include(ue => ue.User)
                                                           .ThenInclude(user => user.Tickets).ThenInclude(t => t.Event)
                                                           .Where(ue => ue.EventId == eventId);

            var users = userEvents.Select(ue => ue.User);
            return users;
        }

        public ApplicationUser GetSingleUser(Guid userId)
        {
            var user = Db.Set<ApplicationUser>().Include(u => u.Tickets)
                                                .FirstOrDefault(u => u.Id == userId);
            return user;
        }
        public void CancelEventForUser(Guid userId, Guid eventId)
        {
            var ticketsToBeRemoved = Db.Set<Ticket>().Include(ticket => ticket.User).Where(ticket => ticket.User.Id == userId && ticket.Event.Id == eventId);
            Db.RemoveRange(ticketsToBeRemoved);
            var userEvent = Db.Set<ApplicationUserEvent>().FirstOrDefault(aue => aue.ApplicationUserId == userId && aue.EventId == eventId);
            Db.Remove(userEvent);
        }
    }
}
